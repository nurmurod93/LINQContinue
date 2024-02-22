//int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 8, 7, 9}; //1) Data sourse - Malumotlar manbasi

//var numQuery = from son in numbers   // 2)Query creation - So'rovni qabul qilish
//               where son % 2==0
//               select son; 

//foreach (var son in numQuery)   //3) Query execution - So'rovni bajarish
//{
//    Console.WriteLine("{0, 1}", son);
//}

//int[] massiv = { -3, -2, -1, 0, 1, 2, 3 };

//IEnumerable<int> sonQuery = from number in massiv where number < 0 select number;

//foreach(var raqam in sonQuery)
//{
//    Console.WriteLine("{0, 1}", raqam);
//}

//int[] array = new int[9] { 11, 12, 13, 14, 15, 16, 17, 18, 19 };

//var evenNumQuery = from number in array
//                   where number % 2 == 0
//                   select number;

//int eventNumberCount = evenNumQuery.Count(); // aggregate funtion so'rov bajarilishini majburlayabdi

//List<int> numQuery2 = (from number in array
//                       where (number %2)==0
//                       select number).ToList(); // ToList() va ToArray() metodlari ham shular jumlasidan

//var numQuery3 = (from number in array 
//                 where (number % 2) == 0
//                 select number).ToArray();