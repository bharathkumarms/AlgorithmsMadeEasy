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
            string e = context.Expression;
            var d = context.Date.Day;
            string day = e.Replace("DD", d.ToString());
            context.Expression = day;
        }
    }
}

/*
 *  var e = new DayExpression();
    var d = new Context();

    d.Expression = "DD/MM/YYYY";
    d.Date = DateTime.Now;
    e.Evaluate(d);
    Console.WriteLine(d.Expression);

    d.Expression = "MM/DD/YYYY";
    d.Date = DateTime.Now;
    e.Evaluate(d);
    Console.WriteLine(d.Expression);


    Console.ReadLine();
 */
