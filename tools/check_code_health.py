#!/usr/bin/env python3
"""检查 C# 代码中的基础语法平衡与 Native 函数引用情况。"""
from __future__ import annotations
import pathlib
import re

ROOT = pathlib.Path(__file__).resolve().parents[1]
CS_FILES = sorted(ROOT.glob("*.cs"))
DOC_FILES = sorted((ROOT / "函数").glob("*.md"))


def strip_comments_and_strings(src: str) -> str:
    src = re.sub(r"//.*", "", src)
    src = re.sub(r"/\*.*?\*/", "", src, flags=re.S)
    src = re.sub(r"@?\"(?:\"\"|\\.|[^\"\\])*\"", '""', src)
    return src


def brace_balance_issues() -> list[str]:
    issues: list[str] = []
    for path in CS_FILES:
        text = strip_comments_and_strings(path.read_text(encoding="utf-8", errors="ignore"))
        depth = 0
        min_depth = 0
        for ch in text:
            if ch == "{":
                depth += 1
            elif ch == "}":
                depth -= 1
                min_depth = min(min_depth, depth)
        if depth != 0 or min_depth < 0:
            issues.append(f"{path.name}: braces imbalance depth={depth}, min={min_depth}")
    return issues


def documented_natives() -> set[str]:
    names: set[str] = set()
    for path in DOC_FILES:
        text = path.read_text(encoding="utf-8", errors="ignore")
        names.update(re.findall(r"`([A-Z0-9_]{3,})`", text))
    return names


def used_natives() -> dict[str, set[str]]:
    pattern = re.compile(r"Function\.Call(?:<[^>]+>)?\(\s*Hash\.([A-Z0-9_]+)")
    used: dict[str, set[str]] = {}
    for path in CS_FILES:
        text = path.read_text(encoding="utf-8", errors="ignore")
        for match in pattern.finditer(text):
            used.setdefault(match.group(1), set()).add(path.name)
    return used


def main() -> int:
    print("== 1) 大括号平衡检查 ==")
    brace_issues = brace_balance_issues()
    if brace_issues:
        for item in brace_issues:
            print("[ERROR]", item)
    else:
        print("[OK] 所有 .cs 文件大括号平衡正常")

    print("\n== 2) Native 函数文档覆盖检查 ==")
    docs = documented_natives()
    used = used_natives()
    missing = sorted(name for name in used if name not in docs)
    print(f"文档中收录 Native 数量: {len(docs)}")
    print(f"代码中使用 Native 数量: {len(used)}")
    print(f"未在 函数/*.md 中检索到的 Native 数量: {len(missing)}")
    for name in missing:
        files = ", ".join(sorted(used[name]))
        print(f"[WARN] {name} -> {files}")

    return 1 if brace_issues else 0


if __name__ == "__main__":
    raise SystemExit(main())
