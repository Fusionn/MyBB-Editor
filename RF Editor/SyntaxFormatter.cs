using System.Text.RegularExpressions;
using System.Web;
using Manoli.Utils.CSharpFormat;

namespace Cyotek.Web.BbCodeFormatter
{
  internal class SyntaxFormatter : RegexFormatter
  {
		#region  Private Member Declarations  

    private SourceFormat _formatter;

		#endregion  Private Member Declarations  

		#region  Public Constructors  

    public SyntaxFormatter(SourceFormat formatter, string pattern, string replace)
      : this(formatter, pattern, replace, true)
    { }

    public SyntaxFormatter(SourceFormat formatter, string pattern, string replace, bool ignoreCase)
      : base(pattern, replace, ignoreCase)
    {
      _formatter = formatter;
    }

		#endregion  Public Constructors  

		#region  Public Overridden Methods  

    public override string Format(string data)
    {
      return base.Regex.Replace(data, SyntaxMatcher);
    }

		#endregion  Public Overridden Methods  

		#region  Private Methods  

    private string SyntaxMatcher(Match match)
    {
      return match.Result(string.Format(base.Replace, _formatter.FormatCode(HttpUtility.HtmlDecode(match.Groups[1].Value)))); // need to call htmldecode as all html was encoded before getting here. If you don't encode the source data, then remove this call.
    }

		#endregion  Private Methods  
  }
}
