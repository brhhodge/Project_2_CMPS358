# Project_2_358
CMPS358_Project2


Project Description:


Average University requires all incoming students to take the course “Becoming an Average Student”. At
the end of the semester, all grades in the course are collected in a text file called – appropriately enough –
“grades.txt”. Each line in the file contains the grades of one student in the course and is organized as
follows:


last-name,first-name,exam-1,exam-2,exam-3


The names are strings. Exam grades are integers in the range of 0 to 100. (Of course, in a text file, the
entire file can be considered a string, just as every line of data can be considered a single string.)
Your job will be to create C# solution to process the data in the file “grades.txt”. First, in Visual Studio
Code, create a project and name it “p2_your-ulid”. Then, download and copy the file “grades.txt” into the
main project folder. Finally, write the C# code to:


1. Read in all data in the file “grades.txt”.


2. From the data read in, calculate the rounded average grade for each student and output this
information to the text file “averages.txt”. Each line of the file will contains the average of one
student and will be organized as follows:


last-name,first-name,average


3. Convert the data read in to XML and store it in the file “grades.xml”.


Tips and Suggestions

• The example “Chapter09/WorkingWithStreams” (as used in class and available via the link given on
‘Moodle Example code for "C# 9 and .NET 5" by Mark J. Price’) is an excellent source of example
code for this assignment.

• Using ReadAllText with a split on the end-of-line character is an easy way to organize the lines of
data in the file into an array. Caveat: This can produce an array with an empty string (a string with
length of zero) at the end, so be sure and compensate or check for this before using the data in an
element of the array.

• Use of Split on a comma on an element on the string containing one line will produce an array of
strings. Using Parse (for instance: Double.parse) can be used to convert the exam grades to a
numeric type.

• Each time a call is made to WriteStartElement(“element-name”), a new element that contain sub
elements is created. Calling WriteEndElement ends the element established by the preceding call to
WriteStartElement.

• The brave can use the XML serialization techniques as shown in
“Chapter09/WorkingWithSerialization”.


Example data taken from “grades.txt”


Adams,Barbara,99,58,89
Adams,Charles,57,73,51
Adams,David,85,67,98
…
Young,Susan,96,60,90
Young,Thomas,81,67,90
Young,William,57,74,65
Example of output to “averages.txt”
Adams,Barbara,82
Adams,Charles,60
Adams,David,83
…
Young,Susan,82
Young,Thomas,79
Young,William,65
Example of output to “grades.xml”
<?xml version="1.0" encoding="utf-8"?>
<Grades>
<student>
<lname>Adams</lname>
<fname>Barbara</fname>
<exam1>99</exam1>
<exam2>58</exam2>
<exam3>89</exam3>
</student>
<student>
<lname>Adams</lname>
<fname>Charles</fname>
<exam1>57</exam1>
<exam2>73</exam2>
<exam3>51</exam3>
</student>
…
<student>
<lname>Young</lname>
<fname>William</fname>
<exam1>57</exam1>
<exam2>74</exam2>
<exam3>65</exam3>
</student>
</Grades>


General requirements:

• Use of Combine(CurrentDirectory, "file-name") to create file paths that end in the main folder /
directory of the project is required for all files.

• At the top of each file containing your C# code, insert the following comments:


// your-name
// your-ulid
// CMPS 358
// project #the-number-of-the-project


Submitting:


When the project runs correctly, clean the project, zip the project folder and upload it in Moodle. The
zip archive name must be the same the required project name (with “.zip” on the end, of course).
