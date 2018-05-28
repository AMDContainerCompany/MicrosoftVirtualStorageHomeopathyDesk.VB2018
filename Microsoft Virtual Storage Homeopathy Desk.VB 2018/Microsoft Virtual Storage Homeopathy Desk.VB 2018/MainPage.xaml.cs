      /// <summary> 
          /// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
          /// </summary> 
[SqlUserDefinedOutputter]
public class ZZONAQQS : IOutputter
{
    private string row_delim;// = Encoding.ASCII.GetBytes("~"); 
    private char[] col_delim;// = new char[] { ',' }; 


    public ZZONAQQS(string trow_del, string tcol_del)
    {
        row_delim = trow_del;
        col_delim = tcol_del.ToCharArray();
    }
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="output"></param> 
    /// <returns></returns> 
    public override void Output(IRow input, IUnstructuredWriter output)
    {
        using (var outputWriter = new StreamWriter(output.BaseStream))
        {
            int columnCount = input.Schema.Count;
            for (int columnIdx = 0; columnIdx < columnCount; columnIdx++)
            {
                if (columnIdx == 2)
                    outputWriter.Write(input.Get<long>(columnIdx));
                else
                    outputWriter.Write(input.Get<string>(columnIdx));
                if (columnIdx == (columnCount - 1))
                    outputWriter.Write(row_delim);
                else
                    outputWriter.Write(col_delim);
            }
        }
    }
}

/// <summary> 
/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedOutputter]
public class ZZONAQQS : IOutputter
{
    private string row_delim;// = Encoding.ASCII.GetBytes("~"); 
    private char[] col_delim;// = new char[] { ',' }; 


    public ZZONAQQS(string trow_del, string tcol_del)
    {
        row_delim = trow_del;
        col_delim = tcol_del.ToCharArray();
    }
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="output"></param> 
    /// <returns></returns> 
    public override void Output(IRow input, IUnstructuredWriter output)
    {
        using (var outputWriter = new StreamWriter(output.BaseStream))
        {
            int columnCount = input.Schema.Count;
            for (int columnIdx = 0; columnIdx < columnCount; columnIdx++)
            {
                if (columnIdx == 2)
                    outputWriter.Write(input.Get<long>(columnIdx));
                else
                    outputWriter.Write(input.Get<string>(columnIdx));
                if (columnIdx == (columnCount - 1))
                    outputWriter.Write(row_delim);
                else
                    outputWriter.Write(col_delim);
            }
        }
    }
}

/// <summary> 
/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedOutputter]
public class ZZONAQQS : IOutputter
{
    private string row_delim;// = Encoding.ASCII.GetBytes("~"); 
    private char[] col_delim;// = new char[] { ',' }; 


    public ZZONAQQS(string trow_del, string tcol_del)
    {
        row_delim = trow_del;
        col_delim = tcol_del.ToCharArray();
    }
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="output"></param> 
    /// <returns></returns> 
    public override void Output(IRow input, IUnstructuredWriter output)
    {
        using (var outputWriter = new StreamWriter(output.BaseStream))
        {
            int columnCount = input.Schema.Count;
            for (int columnIdx = 0; columnIdx < columnCount; columnIdx++)
            {
                if (columnIdx == 2)
                    outputWriter.Write(input.Get<long>(columnIdx));
                else
                    outputWriter.Write(input.Get<string>(columnIdx));
                if (columnIdx == (columnCount - 1))
                    outputWriter.Write(row_delim);
                else
                    outputWriter.Write(col_delim);
            }
        }
    }
}

/// <summary> 
/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedOutputter]
public class ZZONAQQS : IOutputter
{
    private string row_delim;// = Encoding.ASCII.GetBytes("~"); 
    private char[] col_delim;// = new char[] { ',' }; 


    public ZZONAQQS(string trow_del, string tcol_del)
    {
        row_delim = trow_del;
        col_delim = tcol_del.ToCharArray();
    }
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="output"></param> 
    /// <returns></returns> 
    public override void Output(IRow input, IUnstructuredWriter output)
    {
        using (var outputWriter = new StreamWriter(output.BaseStream))
        {
            int columnCount = input.Schema.Count;
            for (int columnIdx = 0; columnIdx < columnCount; columnIdx++)
            {
                if (columnIdx == 2)
                    outputWriter.Write(input.Get<long>(columnIdx));
                else
                    outputWriter.Write(input.Get<string>(columnIdx));
                if (columnIdx == (columnCount - 1))
                    outputWriter.Write(row_delim);
                else
                    outputWriter.Write(col_delim);
            }
        }
    }
}

/// <summary> 
/// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
/// </summary> 
[SqlUserDefinedOutputter]
public class ZZONAQQS : IOutputter
{
    private string row_delim;// = Encoding.ASCII.GetBytes("~"); 
    private char[] col_delim;// = new char[] { ',' }; 


    public ZZONAQQS(string trow_del, string tcol_del)
    {
        row_delim = trow_del;
        col_delim = tcol_del.ToCharArray();
    }
    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="input"></param> 
    /// <param name="output"></param> 
    /// <returns></returns> 
    public override void Output(IRow input, IUnstructuredWriter output)
    {
        using (var outputWriter = new StreamWriter(output.BaseStream))
        {
            int columnCount = input.Schema.Count;
            for (int columnIdx = 0; columnIdx < columnCount; columnIdx++)
            {
                if (columnIdx == 2)
                    outputWriter.Write(input.Get<long>(columnIdx));
                else
                    outputWriter.Write(input.Get<string>(columnIdx));
                if (columnIdx == (columnCount - 1))
                    outputWriter.Write(row_delim);
                else
                    outputWriter.Write(col_delim);
            }
        }
    }
}