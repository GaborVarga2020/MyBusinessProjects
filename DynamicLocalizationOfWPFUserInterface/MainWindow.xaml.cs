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
			Undefined,
			English,
			Hungarian,

			// Add new languages here!

			LanguageCount
		}

		#endregion

		#region Fields

		private System.Collections.Generic.Dictionary<eLanguage, string> m_dictionaryLanguageResources;
		private eLanguage m_eLanguage;

		#endregion

		#region Properties

		private eLanguage RuntimeLanguage
		{
			get
			{
				return m_eLanguage;
			}

			set
			{
				if (m_eLanguage == value)
				{
					// No change in the value, there is nothing to do.
					return;
				}

				m_eLanguage = value;

				System.Diagnostics.Debug.Assert(m_dictionaryLanguageResources.ContainsKey(m_eLanguage));
				string strResourceDictionaryXamlFileName = m_dictionaryLanguageResources[m_eLanguage];
				this.Resources.Source = new Uri(strResourceDictionaryXamlFileName, UriKind.Relative);
				FillLanguageDataCombobox();
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

			RuntimeLanguage = eLanguage.Hungarian;
		}

		#endregion

		#region Methods

		private void EventHandler_ComboboxLanguageSelection_SelectionChanged(object a_sender, SelectionChangedEventArgs a_selectionChangedEventArgs)
		{
			System.Diagnostics.Debug.Assert(a_selectionChangedEventArgs != null);

			if (a_selectionChangedEventArgs.AddedItems.Count == 0)
			{
				return;
			}

			System.Diagnostics.Debug.Assert(a_selectionChangedEventArgs.AddedItems[0] is StructLanguageData);

			StructLanguageData languageData = (StructLanguageData)a_selectionChangedEventArgs.AddedItems[0];

			RuntimeLanguage = languageData.m_eLanguageCode;
		}

		private void FillLanguageDataCombobox()
		{
			ComboboxLanguageSelection.Items.Clear();

			#region Language English

			string strResourceKey = "ComboboxLanguageSelection.Item.English";
			System.Diagnostics.Debug.Assert(this.Resources.Contains(strResourceKey));
			System.Diagnostics.Debug.Assert(this.Resources[strResourceKey].GetType() == typeof(string));
			StructLanguageData languageData = new StructLanguageData(eLanguage.English, (string)this.Resources[strResourceKey]);
			ComboboxLanguageSelection.Items.Add(languageData);

			if (RuntimeLanguage == eLanguage.English)
			{
				ComboboxLanguageSelection.SelectedItem = languageData;
			}

			#endregion

			#region Language Hungarian

			strResourceKey = "ComboboxLanguageSelection.Item.Hungarian";
			System.Diagnostics.Debug.Assert(this.Resources.Contains(strResourceKey));
			System.Diagnostics.Debug.Assert(this.Resources[strResourceKey].GetType() == typeof(string));
			languageData = new StructLanguageData(eLanguage.Hungarian, (string)this.Resources[strResourceKey]);
			ComboboxLanguageSelection.Items.Add(languageData);

			if (RuntimeLanguage == eLanguage.Hungarian)
			{
				ComboboxLanguageSelection.SelectedItem = languageData;
			}

			#endregion
		}

		#endregion
	}
}
