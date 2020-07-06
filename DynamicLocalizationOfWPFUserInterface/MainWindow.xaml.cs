using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DynamicLocalizationOfWPFUserInterface
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		#region Embedded structs

		private struct StructLanguageData
		{
			#region Fields

			public eLanguage m_eLanguageCode;
			public string m_strLanguageText;

			#endregion

			#region Constructors

			public StructLanguageData(eLanguage a_eLanguageCode, string a_strLanguageText)
			{
				m_eLanguageCode = a_eLanguageCode;
				m_strLanguageText = a_strLanguageText;
			}

			#endregion

			#region Methods

			public override string ToString()
			{
				return m_strLanguageText;
			}

			#endregion
		}

		#endregion

		#region Enumerated values

		public enum eLanguage
		{
			English,
			Hungarian,

			// Add new languages here!

			LanguageCount
		}

		#endregion

		#region Fields

		private System.Collections.Generic.Dictionary<eLanguage, string> m_dictionaryLanguageResources;

		#endregion

		#region Properties

		private eLanguage RuntimeLanguage
		{
			get
			{
				return eLanguage.English;
			}

			set
			{
			}
		}

		#endregion

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();

			m_dictionaryLanguageResources = new Dictionary<eLanguage, string>();
			m_dictionaryLanguageResources.Add(eLanguage.English, "MainWindow.ResourceDictionary.en.xaml");
			m_dictionaryLanguageResources.Add(eLanguage.Hungarian, "MainWindow.ResourceDictionary.hu.xaml");

			FillLanguageDataCombobox();

			//this.Resources.Source = new Uri("MainWindow.ResourceDictionary.hu.xaml", UriKind.Relative);
		}

		#endregion

		#region Methods

		private void FillLanguageDataCombobox()
		{
			ComboboxLanguageSelection.Items.Clear();

			string strResourceKey = "ComboboxLanguageSelection.Item.English";
			System.Diagnostics.Debug.Assert(this.Resources.Contains(strResourceKey));
			System.Diagnostics.Debug.Assert(this.Resources[strResourceKey].GetType() == typeof(string));
			StructLanguageData languageData = new StructLanguageData(eLanguage.English, (string)this.Resources[strResourceKey]);
			ComboboxLanguageSelection.Items.Add(languageData);

			--> ToDo: set the item as active if the language is the current one!

			strResourceKey = "ComboboxLanguageSelection.Item.Hungarian";
			System.Diagnostics.Debug.Assert(this.Resources.Contains(strResourceKey));
			System.Diagnostics.Debug.Assert(this.Resources[strResourceKey].GetType() == typeof(string));
			languageData = new StructLanguageData(eLanguage.Hungarian, (string)this.Resources[strResourceKey]);
			ComboboxLanguageSelection.Items.Add(languageData);
		}

		#endregion
	}
}
