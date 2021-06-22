# GlobalX coding challenge

## The Goal: Name Sorter
Build a name sorter. Given a set of names, order that set first by last name, then by any given names the person may have. A name must have at least 1 given name and may have up to 3 given names.

## Usage

Clone the repository in your local machine using the following command.

```c#
git clone https://github.com/ZeeshanM20/globalx-name-sorter.git
```

The project needs a command line argument containing the name of the txt file to read with the unsorted names. A Sample txt file is already in the project which can be used with the following command line argument.
```c#
/unsorted-names-list.txt
```

If running in Visual Studio, you would be required to choose "copy to output directory" property by right clicking on the txt file and going to "quick properties". If this is not done Visual studio would not be able to locate the file. The generated file (sorted-names-list) would also be generated in NameSorter/bin/Debug/net5.0 when using Visual studio.