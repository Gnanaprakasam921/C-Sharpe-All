using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    class Program
    {
        // static List<TraineeDetails> traineeDetails = new List<TraineeDetails>();
        public static void Main(string[] args)
        {

            TraineeData traineeData = new TraineeData();
            List<TraineeDetails> traineeDetailsList = traineeData.GetTraineeDetails();


            System.Console.WriteLine("Enter Choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        var result = from i in traineeDetailsList
                                     select i.TraineeId;


                        foreach (var i in result)
                        {
                            System.Console.WriteLine(i);
                        }
                        break;
                    }

                case 2:
                    {
                        //    var result = traineeDetailsList.TakeWhile(take =>take.ength < 4);



                        //     foreach (var i in result)
                        //     {
                        //         System.Console.WriteLine(i);
                        //     }

                        //         var takeResult = from s in traineeDetailsList
                        //  Take 3
                        //  select s

                        var newList = traineeDetailsList.Take(3);

                        foreach (var i in newList)
                            Console.WriteLine(i.TraineeId);

                        break;
                    }

                case 3:
                    {
                        var skip = traineeDetailsList.Skip(3);
                        foreach (var i in skip)
                        {
                            Console.WriteLine(i.TraineeId);
                        }


                        break;
                    }

                case 4:
                    {
                        var totalcount = traineeDetailsList.Count();
                        System.Console.WriteLine("Number of count:" + totalcount);
                        break;
                    }

                case 5:
                    {
                        // Press 5 to show the Trainee Name who are all passed out 2019 or later

                        // var name=traineeDetailsList.All(s=>s.YearPassedOut>=2019);
                        // System.Console.WriteLine(name);
                        var Result = from s in traineeDetailsList
                                     where s.YearPassedOut >= 2019
                                     select s;
                        foreach (var i in Result)
                        {
                            System.Console.WriteLine(i.TraineeName);
                        }

                        break;
                    }

                case 6:
                    {
                        //Press 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee name.
                        var orderRsult = from s in traineeDetailsList
                                         orderby s.TraineeName
                                         //orderby s.TraineeId
                                         select s;
                        foreach (var i in orderRsult)
                        {
                            System.Console.WriteLine($"{i.TraineeId}    {i.TraineeName}");
                            System.Console.WriteLine();
                        }
                        break;
                    }

                case 7:
                    {
                        // Press 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark
                        //     var Result = from s in 
                        // where s.>=2019
                        // select s;

                        var result= traineeDetailsList.SelectMany(trainee=>trainee.ScoreDetails.Where(score=>score.Mark>=4),
                        (trainee,score)=>new {trainee.TraineeName,trainee.TraineeId,score.TopicName,score.ExerciseName,score.Mark} );
                        foreach (var trainee in result)
                        {
                            System.Console.WriteLine($"{trainee.TraineeId}  {trainee.TraineeName}  {trainee.TopicName}   {trainee.ExerciseName}  {trainee.Mark}");
                        }
                                    
                        break;
                    }

                case 8:
                    {
                        // Press 8 to show the unique passed out year using distinct
                        //var gp=traineeDetailsList.Distinct();
                        var distinctStudents = (from s in traineeDetailsList
                                                select s.YearPassedOut).Distinct();



                        foreach (var std in distinctStudents)
                            Console.WriteLine(std);
                        break;
                    }

                case 9:
                    {
                        //  / Press 9 to show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message
                      foreach(var i in traineeDetailsList)
                      {
                        System.Console.WriteLine(i.TraineeId+":"+i.TraineeName);
                      }
                        System.Console.WriteLine("Enter TraineId");
                        string id=Console.ReadLine();
                        var trainee=traineeDetailsList.FirstOrDefault(trainee=>trainee.TraineeId==id);
                        if(trainee!=null)
                        {
                            int score=trainee.ScoreDetails.Sum(trainee=>trainee.Mark);
                            System.Console.WriteLine($"TotalMark:{id}  {score}");
                        }
                        else
                        {
                            System.Console.WriteLine("invalid ID");
                        }

                          
                        break;
                    }

                case 10:
                    {
                        // Press 10 to show the first Trainee Id and Trainee Name
                        // var newList = traineeDetailsList.Take(1);

                        // foreach (var i in newList)
                        //     Console.WriteLine($"{i.TraineeId}   {i.TraineeName}");

                        var first=traineeDetailsList.First();
                        System.Console.WriteLine(first.TraineeId+":"+first.TraineeName);
                        break;
                    }

                case 11:
                    {
                        // Press 11 to show the last Trainee Id and Trainee Name
                        // var skip = traineeDetailsList.Skip(traineeDetailsList.Count - 1);

                        // System.Console.WriteLine();
                        // foreach (var i in skip)
                        // {
                        //     Console.WriteLine($"{i.TraineeId}   {i.TraineeName}");
                        // }
                        var last=traineeDetailsList.Last();
                        System.Console.WriteLine(last.TraineeId+":"+last.TraineeName);



                        break;
                    }

                case 12:
                    {
                        // Press 12 to print the total score of each trainee
                        foreach(var trainee in traineeDetailsList)
                        {
                            int score=trainee.ScoreDetails.Sum(score=>score.Mark);
                            System.Console.WriteLine(score);

                        }

                        break;
                    }

                case 13:
                    {
                        // Press 13 to show the maximum total score
                         int score=traineeDetailsList.Max(score=>score.ScoreDetails.Sum(add=>add.Mark));
                            System.Console.WriteLine(score);

                        break;
                    }
                case 14:
                    {
                        // Press 14 to show the minimum total score
                         int score=traineeDetailsList.Min(score=>score.ScoreDetails.Sum(add=>add.Mark));
                            System.Console.WriteLine(score);
                        break;
                    }
                case 15:
                    {
                        // Press 15 to show the average of total score
                         double score=traineeDetailsList.Average(score=>score.ScoreDetails.Sum(add=>add.Mark));
                            System.Console.WriteLine(score);
                        break;
                    }

                case 16:
                    {
                        // Press 16 to show true or false if any one has the more than 40 score using any()
                        bool morethan=traineeDetailsList.Any(more=>more.ScoreDetails.Sum(add=>add.Mark)>=40);
                        System.Console.WriteLine(morethan);
                        break;
                    }

                case 17:
                    {
                        // Press 17 to show true of false if all of them has the more than 20 score using all()
                         bool min=traineeDetailsList.Any(more=>more.ScoreDetails.Sum(add=>add.Mark)>=20);
                        System.Console.WriteLine(min);
                        break;
                    }
                case 18:
                    {
                        // Press 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.
                        var details=traineeDetailsList.SelectMany(trainee=>trainee.ScoreDetails,(trainee,score)=>
                                    new {trainee.TraineeId,trainee.TraineeName,score.TopicName,score.ExerciseName, score.Mark})
                                    .OrderByDescending(trainee=>trainee.TraineeName).ThenByDescending(score=>score.Mark);
                                    foreach(var i in details)
                                    {
                                        System.Console.WriteLine(i.TraineeId);
                                        System.Console.WriteLine(i.TraineeName);
                                    }
                        break;
                    }

                    //                   




















            }






        }
    }
}
