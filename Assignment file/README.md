# File Handling in C#

## Introduction

File handling is used to save information in files so we can use it later.

Examples of files are:
- Text files (.txt)
- Document files (.doc)

## File Classes

There are two main classes used in file handling:

**1. StreamWriter**
- It is used to write data into a file.
- It is also used to append new data to a file.

**2. StreamReader**
- It is used to read data from a file.

## Three Steps of File Handling

Every file has three main steps:

1. **Open the file:** Connects the file with the program.
2. **Process the file:** We can write or read data.
3. **Close the file:** Closes the connection between the file and program.

## Opening a File

We use different functions to open files:

- CreateText()  -Creates a new file.
- AppendText()  -Adds new data to an existing file.
- OpenText() -Opens a file for reading.

## Writing to a File

We use the `StreamWriter` class to write data.

It has two methods:

- `Write() - Writes text without starting a new line.
- `WriteLine() -Writes text and moves to the next line.

## Reading from a File

We use the `StreamReader` class to read data.

Some reading methods are:

- `Read() -Reads one character.
- `ReadLine() -Reads one line.
- `ReadToEnd() -Reads all the remaining text.

We can also use loops with `Read()` and `ReadLine()` to read data many times.

`ReadAllText()` is another method that reads the whole file without using a loop. It belongs to the `File` class.

## EndOfStream Property

- It checks if the reader has reached the end of the file.
- It returns `True` or `False`.
- `True` means there is no more data to read.
- `False` means there is still data in the file.

## Appending to a File

Appending means adding new data at the end of an existing file.

- We use `AppendText()`.
- We use `Write()` or `WriteLine()` to add the data.

## Deleting a File or Item

- `File.Delete()` is used to delete a file.
- `Items.RemoveAt()` is used to remove a selected item from a ListBox.

## Closing a File

We use the `Close()` method after reading or writing. It closes the file connection with the program.

## Important Methods

| Method | Use |
|-------------------------
| `CreateText() _ Creates a file 
| `AppendText()` _ Adds new data 
| `OpenText()` _ Opens a file for reading 
| `Write()`   _ Writes text 
| `WriteLine()` _ Writes text on a new line 
| `Read()` _ Reads a character 
| `ReadLine()` _ Reads one line 
| `ReadToEnd()` _ Reads remaining text 
| `ReadAllText()` _ Reads the whole file 
| `EndOfStream` _ Checks the end of the file 
| `File.Delete()` _ Deletes a file 
| `Close()` _ Closes the file 