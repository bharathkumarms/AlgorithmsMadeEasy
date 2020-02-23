using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Interpreter
{
    public class Context
    {
        private DateTime date;
        private string expression;

        public DateTime Date { get => date; set => date = value; }
        public string Expression { get => expression; set => expression = value; }
    }

    public abstract class AbstractExpression
    {
        public abstract void Evaluate(Context context);
    }

    public class DayExpression : AbstractExpression
    {
        public override void Evaluate(Context context)
        {
            string s = context.Expression;
            var d = context.Date.Day;
            string day = s.Replace("DD", d.ToString());
            context.Expression = day;
        }
    }

    public class MonthExpression : AbstractExpression
    {
        public override void Evaluate(Context context)
        {
            string s = context.Expression;
            var m = context.Date.Month;
            string month = s.Replace("MM", m.ToString());
            context.Expression = month;
        }
    }

    public class YearExpression : AbstractExpression
    {
        public override void Evaluate(Context context)
        {
            string s = context.Expression;
            var y = context.Date.Year;
            string year = s.Replace("YYYY", y.ToString());
            context.Expression = year;
        }
    }
}

/*
 *  var c = new Context();
    c.Expression = "DD/MM/YYYY";
    c.Date = DateTime.Now;

    var e = new DayExpression();
    var m = new MonthExpression();
    var y = new YearExpression();
    e.Evaluate(c);
    m.Evaluate(c);
    y.Evaluate(c);
    Console.WriteLine(c.Expression);

    c.Expression = "MM/DD/YYYY";
    c.Date = DateTime.Now;
    e.Evaluate(c);
    m.Evaluate(c);
    y.Evaluate(c);
    Console.WriteLine(c.Expression);

    Console.ReadLine();
 */
