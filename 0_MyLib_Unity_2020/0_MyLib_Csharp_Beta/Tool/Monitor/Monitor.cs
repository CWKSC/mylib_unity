namespace MyLib_Csharp_Beta.Tool
{

    /// <summary>
    /// Monitor value, return ture when value is change, else false 
    /// <code>
    /// Monitor&lt;int&gt; monitor = new Monitor&lt;int&gt;(1); <br />
    /// monitor.IsChange(2).Println(); // value change, return ture  <br />
    /// monitor.IsChange(2).Println(); // false  <br />
    /// </code>
    /// </summary>
    public class Monitor<T>
    {
        public T target;
        public Monitor(T init) => target = init;
        public bool IsChange(T input)
        {
            bool result = !target.Equals(input);
            target = input;
            return result;
        }
    }

}
