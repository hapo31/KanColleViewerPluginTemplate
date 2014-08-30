提督業も忙しい！用Pluginテンプレート
--

  提督業も忙しい！用プラグインのテンプレートプロジェクトです。
　　[提督業も忙しい！](https://github.com/Grabacr07/KanColleViewer) 様のリポジトリを利用する形になります。
  よって単体ではビルド出来ませんのでご注意ください。
  **自分用なので特に使ってもらおうという意図はありません。 Pull Requestはご自由にどうぞ（多分ないけど）**

### 自分用メモ

  PluginEntry.csのNameプロパティの返す値を変えることでビュワー側に表示される名前が変わる。

  GetToolView()はよく分からないけどサンプルがnullだったのでnullでいいと思う。
  GetSettingView()は、ViewModelクラスを継承したクラスのDataContextに、MainWindow.xamlで呼ぶモジュールを渡してビューを返す。

  例
  `
	private readonly ExampleViewModel viewmodel = new ExampleViewModel
	{
		// args...
	};

	public object GetToolView()
	{
		//どっかにpublic class ExampleView : ViewModel{}っていうのがあるとする
		return new ExampleView { DataContext = this.viewmodel, };
	}
	`

　　正直自分自身がWPF分かってなさすぎてインスタンスがどう扱われるのかがいまいち分かってない。
  勉強すること。

  [EOF]