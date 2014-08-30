提督業も忙しい！用Pluginテンプレート
--

** ＊注意＊ [本家様](https://github.com/Grabacr07/KanColleViewer)とは無関係のリポジトリです。ご留意ください。 **

提督業も忙しい！用プラグインのテンプレートプロジェクトです。  
[提督業も忙しい！](https://github.com/Grabacr07/KanColleViewer) 様のリポジトリを利用する形になります。  
よって単体ではビルド出来ませんのでご注意ください。  

**自分用なので特に使ってもらおうという意図はありません。 Pull Requestはご自由にどうぞ（多分ないけど）**  

### ビルド方法
  
Visual Studioで提督業も忙しい！のソリューションを開き、こいつの.csprojを追加して取り敢えずビルドしてみる。  
通らなかったら本家で使われてるモジュールが参照できる状態かを確認する。  
ていうか本家のビルドが通ればこいつも通るはず。  
あとは頑張る。  

### 自分用メモ

PluginEntry.csのToolNameプロパティの返す値を変えることでビュワー側に表示される名前が変わる。  

GetSettingView()はよく分からないけどサンプルがnullだったのでnullでいいと思う。  
GetToolView()は、ViewModelクラスを継承したクラスのDataContextに、MainWindow.xamlで呼ぶモジュールを渡してビューを返す。  

例  

	private readonly ExampleViewModel viewmodel = new ExampleViewModel
	{
		// args...
	};
	public object GetToolView()
	{
		//どっかにpublic class ExampleView : ViewModel{}っていうのがあるとする
		return new ExampleView { DataContext = this.viewmodel, };
	}

正直自分自身がWPF分かってなさすぎてインスタンスがどう扱われるのかがいまいち分かってない。  
勉強すること。  

[EOF]  