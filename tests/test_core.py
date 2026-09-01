import pytest
import os

def test_project_manifest_integrity():
    assert os.path.exists("README.md")
    assert os.path.exists("AGENTS.md")
    assert os.path.exists("PROJECT_STATUS.md")
    assert os.path.exists("index.html")

def test_no_mit_license_badges():
    content = open("README.md", encoding="utf-8").read()
    assert "shields.io/badge/License-MIT" not in content
    assert "img.shields.io" not in content
