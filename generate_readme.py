#!/usr/bin/env python3
import json
import os
from pathlib import Path

def format_section_name(filename):
    return filename.replace('.json', '').replace('_', ' ').title()

def format_anchor_link(section_name):
    return section_name.lower().replace(' ', '-')

def read_text_file(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        return f.read()

def read_json_file(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        return json.load(f)

def generate_readme():
    json_files = sorted([f for f in Path('examples').glob('*.json')])
    
    readme_content = []
    header_file = Path('README.header.md')
    readme_content.extend(read_text_file(header_file).strip().split('\n'))
    
    # Table of Contents
    readme_content.append("## Table of Contents")
    readme_content.append("")
    for filepath in json_files:
        section_name = format_section_name(filepath.name)
        anchor = format_anchor_link(section_name)
        readme_content.append(f"- [{section_name}](#{anchor})")
    readme_content.append("")
    
    # Examples section
    readme_content.append("## Examples")
    readme_content.append("")
    
    for filepath in json_files:
        section_name = format_section_name(filepath.name)
        readme_content.append(f"### {section_name}")
        
        data = read_json_file(filepath)
        readme_content.append("```json")
        readme_content.append(json.dumps(data, indent=4))
        readme_content.append("```")
        readme_content.append("")
    
    # Write to README.md
    with open('README.md', 'w', encoding='utf-8') as f:
        f.write('\n'.join(readme_content))
    
    print("README.md generated successfully!")

if __name__ == "__main__":
    generate_readme()