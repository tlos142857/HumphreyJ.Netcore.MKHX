﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HumphreyJ.NetCore.MKHX.SandBox.Models.SkillAffectType
{
    internal abstract partial class SkillAffectType
    {
        public class _9_冰弹 : SkillAffectType
        {
            protected _9_冰弹(string[] AffectValue, string[] AffectValue2) : base(9, AffectValue, AffectValue2) {

                {
                    cardCount = 1;
                    number = double.Parse(AffectValue[0]);
                    percentage = double.Parse(AffectValue2[0]) / 100;
                }

                {
                    SkillPercentageAll = Math.Pow(percentage, cardCount);
                }

                {
                    var p = new List<double>();
                    for (var i = 0; i < cardCount; i++)
                    {
                        p.Add(Math.Pow(percentage, i));
                    }
                    SkillPercentageMean = p.Average();
                }


            }

            public override string AffectTypeName => "冰弹";

            public override double SkillPercentageAll { get; }

            public override double SkillPercentageMean { get; }

            //  使敌方1张卡牌受到{number}点冰冻伤害。并有{percentage}%概率丧失下一个行动回合。 
            //  完整发动概率为卡牌受影响的概率
            //  期望为卡牌受影响的概率

            private readonly int cardCount;
            private readonly double number;
            private readonly double percentage;
        }

    }
}