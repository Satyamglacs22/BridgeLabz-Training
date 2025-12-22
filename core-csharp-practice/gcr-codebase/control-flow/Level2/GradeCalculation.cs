using System;
public class GradeCalculation{
public static void Main(){
int physics=int.Parse(Console.ReadLine());
int chemistry=int.Parse(Console.ReadLine());
int maths=int.Parse(Console.ReadLine());

double avg=(physics+chemistry+maths)/3.0;
string grade,remark;

if(avg>=80){
grade="A";
remark="Level 4, above agency-normalized standards";
}
else if(avg>=70){
grade="B";
remark="Level 3, at agency-normalized standards";
}
else if(avg>=60){
grade="C";
remark="Level 2, below but approaching agency-normalized standards";
}
else if(avg>=50){
grade="D";
remark="Level 1, well below agency-normalized standards";
}
else if(avg>=40){
grade="E";
remark="Level 1, too below agency-normalized standards";
}
else{
grade="R";
remark="Remedial standards";
}

Console.WriteLine($"Average Marks: {avg}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"Remarks: {remark}");
}
}
