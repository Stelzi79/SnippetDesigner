using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.SnippetDesigner
{
    public enum Language
    {
        CSharp,
        VisualBasic,
        XML
    }

    /// <summary>
    /// Provides maps of different forms of the programming language names to eachother
    /// </summary>
    public class LanguageMaps
    {

        public static LanguageMaps LanguageMap = new LanguageMaps();

        //hash that maps what the scnippet schema names of the programming languages are to the dispaly names we use
        private Dictionary<string, string> snippetSchemaLanguageToDisplay = new Dictionary<string, string>();
        //hash that maps what the display names of the programming languages are to the xml names the snippet schema specifies
        private Dictionary<string, string> displayLanguageToXML = new Dictionary<string, string>();

        public Dictionary<string, string> SnippetSchemaLanguageToDisplay
        {
            get
            {
                return snippetSchemaLanguageToDisplay;
            }
        }

        public Dictionary<string, string> DisplayLanguageToXML
        {
            get
            {
                return displayLanguageToXML;
            }
        }

        /// <summary>
        /// Toes the display form.
        /// </summary>
        /// <param name="lang">The lang.</param>
        /// <returns></returns>
        public String ToDisplayForm(Language lang)
        {
            switch (lang)
            {
                case Language.CSharp:
                    return Resources.DisplayNameCSharp;
                case Language.VisualBasic:
                    return Resources.DisplayNameVisualBasic;
                case Language.XML:
                    return Resources.DisplayNameXML;
                default:
                    return String.Empty;
            }
        }

        /// <summary>
        /// Toes the schema form.
        /// </summary>
        /// <param name="lang">The lang.</param>
        /// <returns></returns>
        public String ToSchemaForm(Language lang)
        {
            switch (lang)
            {
                case Language.CSharp:
                    return ConstantStrings.SchemaNameCSharp;
                case Language.VisualBasic:
                    return ConstantStrings.SchemaNameVisualBasic;
                case Language.XML:
                    return ConstantStrings.SchemaNameXML;
                default:
                    return String.Empty;
            }
        }
        /// <summary>
        /// maps form one lang form to another
        /// </summary>
        public LanguageMaps()
        {
            //hash from schema names to display names
            snippetSchemaLanguageToDisplay[ConstantStrings.SchemaNameVisualBasic] = Resources.DisplayNameVisualBasic;
            snippetSchemaLanguageToDisplay[ConstantStrings.SchemaNameCSharp] = Resources.DisplayNameCSharp;
            snippetSchemaLanguageToDisplay[ConstantStrings.SchemaNameCSharp2] = Resources.DisplayNameCSharp;
            snippetSchemaLanguageToDisplay[ConstantStrings.SchemaNameXML] = Resources.DisplayNameXML;
            snippetSchemaLanguageToDisplay[String.Empty] = String.Empty;

            //has from display names to schema names
            displayLanguageToXML[Resources.DisplayNameVisualBasic] = ConstantStrings.SchemaNameVisualBasic;
            displayLanguageToXML[Resources.DisplayNameCSharp] = ConstantStrings.SchemaNameCSharp;
            displayLanguageToXML[Resources.DisplayNameXML] = ConstantStrings.SchemaNameXML;
            displayLanguageToXML[String.Empty] = String.Empty;
            
        }
    }
}
