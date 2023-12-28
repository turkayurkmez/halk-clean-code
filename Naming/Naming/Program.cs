// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
int i = 0;
int d = 120; //Müşterinin kayıt olduğu tarihten bu yana geçen gün sayısı
int day = 120;
int daysSinceUserCreatedOnDb = 120;

int kullaniciKacGundurKayitli = 120;

//bool banuAlkan = false;

var hitPoint = 100;

//takım lideri karar alır....
var cities = new List<string>();
var cityList = new List<string>();

string stringName = "Türkay";
int count = 4;
Random randomNumberGenerator = new Random();
FileStream reportFileStream = null;
DataTable customersDataTable = null;

bool isCanceled = false;
//if (isCanceled)
//{

//}
//var o = 0;
//var l = 1;

//if (o==l)
//{
//    l = 1;
//}

List<int[]> cellsOnABoard = new List<int[]>();

List<int[]> getFlaggedCellsOnGameBoard()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cellsOnABoard)
    {
        if (cell[0] == 4)
        {
            flaggedCells.Add(cell);
        }
    }
    return flaggedCells;
}


