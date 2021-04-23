// Brian Hodge
// CMPS 358
// C00170400
// Project #2

using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Xml;

namespace p2_C00170400
{
    class Program
    {
        static void readFromFileAndOutput()
        {           

            // define file paths
            string textFile = Combine(CurrentDirectory, "averages.txt");
            //string backupFile = Combine(CurrentDirectory, "averages.bak");
            StreamWriter textWriter = File.CreateText(textFile);

        
            string[] texty = System.IO.File.ReadAllLines(@"C:\Users\brian\Documents\VSCode_Projects\p2_C00170400\grades.txt");

            string xmlFile = Combine(CurrentDirectory, "grades.xml");

            FileStream xmlFileStream = File.Create(xmlFile);

            XmlWriter xml = XmlWriter.Create(xmlFileStream,
                new XmlWriterSettings { Indent = true });

            xml.WriteStartDocument();

            xml.WriteStartElement("Grades");

            int i = 2;
            foreach (string line in texty)
            {

                var grade1 = line.ToString().Split(",", 5);
                var grade2 = line.ToString().Split(",", 5);
                var grade3 = line.Split(",", 5);
                //Console.Write("\t" + grade1.GetValue(i) + " ");      //Console Output
                //Console.Write("\t" + grade2.GetValue(i + 1) + " ");
                //Console.WriteLine("\t" + grade3.GetValue(i + 2));


                var G1 = Convert.ToDouble(grade1.GetValue(i));
                var G2 = Convert.ToDouble(grade1.GetValue(i + 1));
                var G3 = Convert.ToDouble(grade1.GetValue(i + 2));

                string lastName = Convert.ToString(grade1.GetValue(0));
                string firstName = Convert.ToString(grade1.GetValue(1));

                var gradeTotal = (G1 + G2 + G3);
                double gradeAvg = (gradeTotal / 3);
                //Console.WriteLine("Average Grade:" + " " + Math.Round(gradeAvg));  //Console Output

             textWriter.WriteLine(grade1.GetValue(0) + "," + grade1.GetValue(1) + "," + Math.Round(gradeAvg));
                
                xml.WriteStartElement("student");
                    xml.WriteElementString("lname", lastName);
                    xml.WriteElementString("fname", firstName);
                    xml.WriteElementString("exam1", G1.ToString());
                    xml.WriteElementString("exam2", G2.ToString());
                    xml.WriteElementString("exam3", G3.ToString());
                xml.WriteEndElement();
                
            }
            
            textWriter.Close();
            xml.WriteEndElement();
            xml.Close();
            xmlFileStream.Close();
            
        }   
        private static void Main(string[] args)
        {
            readFromFileAndOutput();
        }


    }
}
