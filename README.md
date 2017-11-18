# mididump2csv
Convert a human readable midi txt file, made with mididump, to csv

Usage:

Put the program in your path. Then call the program passing the midi dump file via standard input with redirection

Examples:
mididump2csv < test.txt

OR (using 'cat' on linux)
cat test.txt | mididump2csv

OR (using 'type' on windows)
type test.txt | mididump2csv

The output will be written to the standard output. To write it to a file, use output redirection:

Examples:
mididump2csv < test.txt > test.csv

cat test.txt | mididump2csv > test.csv
