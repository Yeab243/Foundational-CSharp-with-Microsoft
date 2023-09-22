int currentAssignments = 5;

int james1 = 93;
int james2 = 87;
int james3 = 98;
int james4 = 95;
int james5 = 100;

int sanchez1 = 80;
int sanchez2 = 83;
int sanchez3 = 82;
int sanchez4 = 88;
int sanchez5 = 85;

int nebil1 = 84;
int nebil2 = 96;
int nebil3 = 73;
int nebil4 = 85;
int nebil5 = 79;

int donald1 = 90;
int donald2 = 92;
int donald3 = 98;
int donald4 = 100;
int donald5 = 97;

int jamesSum = james1 + james2 + james3 + james4 + james5;
int sanchezSum = sanchez1 + sanchez2 + sanchez3 + sanchez4 + sanchez5;
int nebilSum = nebil1 + nebil2 + nebil3 + nebil4 + nebil5;
int donaldSum = donald1 + donald2 + donald3 + donald4 + donald5;

decimal jamesScore = (decimal) jamesSum / currentAssignments;
decimal sanchezScore = (decimal) sanchezSum / currentAssignments;
decimal nebilScore = (decimal) nebilSum / currentAssignments;
decimal donaldScore = (decimal) donaldSum / currentAssignments;

Console.WriteLine("James: " + jamesScore + " A");
Console.WriteLine("Sanchez: " + sanchezScore + " B");
Console.WriteLine("Nebil: " + nebilScore + " B");
Console.WriteLine("Donald: " + donaldScore + " A");
