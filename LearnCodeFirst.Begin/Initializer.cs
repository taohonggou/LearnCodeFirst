﻿using LearnCodeFirst.Begin.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCodeFirst.Begin
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            //context.PayWays.AddRange(new List<PayWay>
            //{
            //    new PayWay {Name="支付宝" },
            //    new PayWay {Name="微信" },
            //    new PayWay {Name="QQ钱包" },
            //});
        }
    }
}
