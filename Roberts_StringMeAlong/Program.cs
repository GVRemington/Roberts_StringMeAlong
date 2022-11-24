// See https://aka.ms/new-console-template for more information
//Roberts, Raylee
//IT 113
//Notes: 
//Behaviors Not Implemented: symmetrical and backwards are the only ones that
//                           are working 100% correctly
//                           case preservation doesn't work at all
//                           ASCII gets the correct number for each name
//                           something wrong with loop logic to get it out to 
//                           a string because I seem to be forgetting how to print 
//                           a stupid array >:(  


using Roberts_StringMeAlong;
using System.Text;

StringManager doStuffToString = new StringManager();


Console.WriteLine(doStuffToString.goBackwards("Hello Everybody"));

Console.WriteLine(doStuffToString.asciiValue("Larry"));
Console.WriteLine(doStuffToString.asciiValue("Fred"));

Console.WriteLine(doStuffToString.symmetric("ABBA"));
Console.WriteLine(doStuffToString.symmetric("Abba"));

//Console.WriteLine(doStuffToString.casePreservation("Lets Give This A Try"));//not working correctly I remarked it out
