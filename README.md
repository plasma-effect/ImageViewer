# ImageViewer
画像のプレビュー、及び複数の画像をアルバムとして記録するソフトウェアです。当ソフトウェアはMIT LICENSEの下で公開されています。詳しくは[LICENSE](./LICENSE)を御覧ください。
# 基本的な使い方
ソフトウェアを起動すると「画像ファイル一覧を表示するウィンドウ」と「画像を表示するウィンドウ」が2つ立ち上がります。以下では「画像ファイル一覧を表示するウィンドウ」の使い方を説明します。
## フォルダを選択する
「ファイル」→「フォルダを開く」から開きたいフォルダを選択します。フォルダを開くと以下が一覧として表示されます
- そのフォルダを含んでいる親のフォルダ
- そのフォルダが含んでいる子のフォルダ
- そのフォルダ内にある画像ファイル

このソフトウェアでは以下の拡張子のファイルに対応しています。
- .bmp
- .gif
- .jpeg
- .jpg
- .jpe
- .jfif
- .jfi
- .jif
- .png
- .tiff
- .tif

またフォルダをドロップして起動することで、そのフォルダを開いた状態で開始することができます。
## 画像を表示する
一覧の画像ファイルの名前をクリックすることで、もう片方のウィンドウにその画像ファイルが表示されます。
## 隣の画像に移動する
画像が表示されているときに方向キーの上下を押すと、押した方向の画像に切り替えることができます。
## 親のフォルダに移動する
現在表示されているフォルダに親のフォルダが存在する場合、一覧の一番上に「..」と表示されます。これをクリックすると親のフォルダに移動することができます。
## 子のフォルダに移動する
拡張子が表示されていない名前は現在表示されているフォルダに含まれる子フォルダです。これをクリックするとそのフォルダに移動することができます。
# アルバム機能を使う
アルバム機能を使うことで複数のフォルダにある画像ファイルをまとめることができます。
## アルバムを新規作成する
「ファイル」→「アルバムを新規作成」でアルバムを新規作成できます。
## アルバムに画像ファイルを追加する
アルバムに画像ファイルを追加する方法は3つあります。
### ファイルごとに追加する
追加したい画像ファイルのファイル名を右クリックし「アルバムに追加」を選択すると、その画像ファイルがアルバムに追加されます。
### 子フォルダのファイルを全て追加する
子フォルダのフォルダ名を右クリックし「フォルダ全てをアルバムに追加」を選択すると、そのフォルダにある当ソフトウェアに対応したファイルを全てアルバムに追加します。
### 現在のフォルダのファイルを全て追加する
「ファイル」→「フォルダ内の画像を全てアルバムに追加」と選択することで、現在のフォルダないの画像ファイルを全てアルバムに追加します。
## アルバムの画像を表示する
アルバムにあるファイル名をクリックすると、その画像ファイルを表示することができます。また方向キーの上下で押した方向の画像ファイルに切り替えることができます。
## アルバムの順番を変える
アルバムに画像ファイルが追加されると、その画像ファイルは最後尾に配置されます。画像ファイルの順番を変える方法は以下の4つがあります。
### 隣と入れ替える
画像ファイルが表示されているときに「Shift+上キー」もしくは「Shift+下キー」で隣のファイルと順番を入れ替えることができます。
### 名前順でソート
「アルバム」→「名前順でソート」とするとファイル名でソートできます。
### 最終更新日時でソート
「アルバム」→「最終更新日時でソート」とすると最終更新日時でソートできます。
### アルバムをシャッフルする
「アルバム」→「順番をシャッフルする」とするとアルバムの順番がシャッフルされます。
## アルバムに名前をつけて保存する
「ファイル」→「アルバムを別名保存」とするとアルバムに名前をつけて保存することができます。
## アルバムを同じ名前で保存する
「ファイル」→「アルバムを保存」とすると上書き保存します。ただし新規作成アルバムの場合は「アルバムを別名保存」と同じ挙動になります。
## アルバムを開く
「ファイル」→「アルバムを開く」でアルバムを開くことができます。また最近扱ったアルバムは10件まで保存されます。
# その他
## フォント/サイズを変更する
「設定」→「フォント/サイズの変更」で当ソフトウェアで使われるフォントを変更することができます。
## 使い方ガイドを開く
「ヘルプ」→「使い方ガイド」でこのファイルがブラウザで開かれます。
## バージョン情報を見る
「ヘルプ」→「バージョン情報」でバージョン情報と当ソフトウェアで使われている外部ライブラリの確認ができます。
# ショートカットキーについて
当ソフトウェアにはショートカットキーが設定されています。
- Ctrl+F フォルダを開く
- Ctrl+O アルバムを開く
- Ctrl+N アルバムの新規作成
- Ctrl+S アルバムの上書き保存