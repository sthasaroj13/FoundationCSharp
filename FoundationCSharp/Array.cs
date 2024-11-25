//one dimenssion array
int[] marks = new int[5]; // new is  dymanic memory in c# 

for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine("Enter the Student mark:");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}
// this is for loop 
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine("The total marks are :" + marks[i]);
}
// this is for each loop
foreach (int i in marks)
{
    Console.WriteLine("The student marks are:" + i);
}
//multi - dimenssion array]

int[,] marks2 = new int[2,2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine($"Enter the marks of student :");
        marks2[i,j]= Convert.ToInt32(Console.ReadLine());
    }

}
for (int i = 0;i< 2; i++)
{
    for(int j = 0;j < 2; j++)
    {
        Console.WriteLine($"Marks at position:"+ marks2[i, j]);
    }
}