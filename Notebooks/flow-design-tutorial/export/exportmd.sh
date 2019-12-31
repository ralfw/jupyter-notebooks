rm -r export_md
mkdir export_md

# find . -type f -name "*.ipynb"
for file in ./*.ipynb
do
	jupyter nbconvert "$file" --to markdown --output export_md/"$file".md
done
ren export_md/*.ipynb.md *.md