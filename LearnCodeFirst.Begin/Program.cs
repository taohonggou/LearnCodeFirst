using LearnCodeFirst.Begin.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCodeFirst.Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new Initializer());

            using (Context context = new Context())
            {
                //如果数据库不存在时创建
                //context.Database.CreateIfNotExists();
                #region 1.添加记录
                //var donators = new List<Donator>
                //{
                //    new Donator
                //    {
                //      Name   = "陈志康",
                //      Amount = 50,
                //      DonateDate = new DateTime(2016, 4, 7)
                //    },
                //    new Donator
                //    {
                //        Name = "海风",
                //        Amount = 5,
                //        DonateDate = new DateTime(2016, 4, 8)
                //    },
                //    new Donator
                //    {
                //        Name = "醉千秋",
                //        Amount = 18.8m,
                //        DonateDate = new DateTime(2016, 4, 15)
                //    }
                //};

                //context.Donators.AddRange(donators);
                //context.SaveChanges(); 
                #endregion

                #region 2.查询记录
                //var donators = context.Donators;
                //Console.WriteLine($"DonatorId\t\tName\t\tAmount\t\tDonateDate");
                //foreach (var donator in donators)
                //{
                //    Console.WriteLine($"{donator.DonatorId}\t\t{donator.Name}\t\t{donator.Amount}\t\t{donator.DonateDate}");
                //}


                #endregion

                #region 3.更新记录
                //if(context.Donators.Any())
                //{
                //    var donator = context.Donators.FirstOrDefault(o => o.Name == "醉千秋");
                //    donator.Name = "醉、千秋";
                //    context.SaveChanges();
                //}
                #endregion

                #region 4.删除
                //var deleteDonator = context.Donators.FirstOrDefault(o => o.Name == "待打赏");
                //if (deleteDonator != null)
                //{
                //    context.Donators.Remove(deleteDonator);
                //    context.SaveChanges();
                //}
                #endregion

                #region 6. 一对多关系
                //var donator = new Donator { DonateDate = DateTime.Parse("2017-03-15"), Amount = 6, Name = "键盘里的鼠标" };
                //donator.PayWays.Add(new PayWay { Name = "微信" });
                //donator.PayWays.Add(new PayWay { Name = "支付宝" });

                //context.Donators.Add(donator);
                //context.SaveChanges();

                #region 6.1 一对多关系 例子2
                //var donatorTypeOne = new DonatorType
                //{
                //    Name = "博客园园友",
                //    Donators = new List<Donator>
                //    {
                //        new Donator
                //        {
                //            Amount=6,Name="键盘里的鼠标",DonateDate=DateTime.Now,
                //            PayWays=new List<PayWay>{new PayWay { Name="支付宝"},new PayWay { Name="微信"} }
                //        },
                //    },
                //};

                //var donatorTypeTwo = new DonatorType
                //{
                //    Name = "非博客园园友",
                //    Donators = new List<Donator>
                //    {
                //        new Donator
                //        {
                //            Amount=10,Name="带赞助",DonateDate=DateTime.Now,
                //            PayWays=new List<PayWay>{new PayWay { Name="支付宝"},new PayWay { Name="微信"} }
                //        },
                //    },
                //};

                //context.DonatorTypes.Add(donatorTypeOne);
                //context.DonatorTypes.Add(donatorTypeTwo);
                //context.SaveChanges();
                #endregion

                #endregion

                #region 7. 一队一关系
                //var student = new Student
                //{
                //    CollegeName = "石家庄学院",
                //    EnrollmentDate = DateTime.Parse("2016-06-20"),
                //    Person = new Person
                //    {
                //        Name = "陈亮",
                //    }
                //};

                //context.Students.Add(student);
                //context.SaveChanges();

                //var stuents= context.Students.ToList();
                //var persons = context.Persons.ToList();
                #endregion
            }

            Console.WriteLine("Success");
            Console.ReadKey();
        }
    }
}
