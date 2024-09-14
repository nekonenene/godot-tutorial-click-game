# Tutorial Click Game

https://2dgames.jp/godot4-clickgame-tutorial/ をもとに作成しました。

C# で書き直すには情報が少なく苦労しました……。


## 開発するには……

- [Godot Engine](https://godotengine.org) .NET 4.3
- [.NET SDK](https://learn.microsoft.com/ja-jp/dotnet/core/install/macos)

が必要です。

`brew install --cask dotnet` でインストールすると .NET ランタイムしか入らなくて  
.NET SDK がないことでビルドに失敗したので、  
https://dotnet.microsoft.com/ja-jp/download/dotnet/8.0 のページで SDK をインストールする方法がおすすめです。

インストール後は `/usr/local/share/dotnet` にインストールされるので、 `~/.zshrc` などに以下の記載を追加してください。

```sh
export PATH="/usr/local/share/dotnet:$PATH"
```

また、 Visual Studio Code の [C# 拡張機能](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) の  
Language Server が動いていない場合は、「Dotnet Path」の設定に `/usr/local/share/dotnet` を記載してください。  
それでコード補完が働くようになります。
