# This is the first challenge: challenge 1 - sort it out

## The Docs from microsoft:

### string comparison :

https://docs.microsoft.com/en-us/dotnet/api/system.string.compare?view=net-6.0

### Culture info :

https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-6.0#CultureNames

### Available cultures from microsoft :

https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-lcid/a9eac961-e77d-41a6-90a5-ce1a8b0cdb9c

## The program utilises 2 for-loops:

The first Loop is to iterate the items of the string list.

The second loop is used to compare the current item with the rest of the items to find the one which has the required order and its position.

After the second loop finishes, the list is re-arranged.

A small example has been given inside the class "oderList".

## The comparison of the list strings:

The program can use 2 different methods to compare the items inside the list

1. The simple "compareTo()" method
2. The "string.compare()" method:

The second method is used due to its functionality to change the culture info that will be used to compare and order the strings inside the list
en-150 has been used due to it being classified as the culture info for europe as a whole by microsoft

To run this project {src/orderList}, just type:
`dotnet run`
To test this project {src/orderListTest}, just type
`dotnet test`