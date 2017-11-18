# mididump2csv
Convert a human readable midi txt file, made with mididump, to csv

# Disclaimer
This "midi csv" midi event format is not some kind of industry standard (even though the csv itself is a very old industry standard). It is just some modifications made to the output of NAudios midi event strings. Because the output of NAudio is not meant to be rigidly structured text, one can not just split the string using white space or other character. mididump2csv just adjust the data and use the commonly known csv format to make the data more easy to be parsed by other software

# Usage:

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
