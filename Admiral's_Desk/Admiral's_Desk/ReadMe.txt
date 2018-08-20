■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

　　　　　　「艦隊これくしょん－艦これ－」専用ブラウザ
　　　　　　　　Admiral's Desk ver0.2.0.3α ReadMe

　　　　　　　by ますたー。 (Twitter:@masteralice3104)
　　　
■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿

【目次】
　　　０．　　注意・免責事項など
　　　１．　　コンセプト・概要
　　　２．　　インストール・動作環境について
　　　３－１．特徴
　　　３－２．技術的(簡易)解説
　　　４．　　簡単な使い方・機能説明
　　　５．　　ソフトウエア設定の初期化について
　　　６．　　Ｑ＆Ａ
　　　７．　　更新ログ
　　　８．　　ライセンス

＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿




【０．注意・免責事項など】
　　　このソフトウエア「Admiral's Desk」はフリーソフトです。
　　　このソフトウエアを使用したことによって生じたいかなる障害・損害・不具合等に関しては、作者は一切の責任を負いません。
　　　各自の責任においてご利用ください。

　　　同梱されているこのソフトウエアは現在＜＜α版＞＞となります。β版ですらありません。
　　　そのため非常に動作が不安定となっております。その点を了承の上ご利用ください。
　　　バグや不審な動作、おかしな表現などの異常を発見されましたら、この専用ブラウザのTwitter(@Admiral_s_Desk)または作者Twitter(@masteralice3104)までご一報ください。

　　　2018年の2期への移行については順次仕様変更へ対応しております。
　　　ただし当バージョンでは2期Block-1以外の対応はいたしません。バージョンアップをお待ち下さい。
　　　またデバッグ不足により深刻なバグが発生する可能性があります。十分注意の上ご利用ください。



【１．コンセプト・概要】
　　　「艦これをプレイする時、専ブラって情報量が多い！」と感じた作者が「必要な時、必要なだけ」情報を表示できるようにと思い作った専用ブラウザです。
　　　ながらプレイする用途から海域攻略まで全てをこれ一つで賄えるようなブラウザを目指して開発中です。



【２．インストール・動作環境について】
　　　インストールの方法は、お好きな場所に"Admiral_s_Desk"フォルダを解凍するだけです。

　　　起動には.NET Framework 4.6.2が必要です。
　　　起動できなかった場合はインストールされているかどうかを確認してください。
　　　
　　　Windows10　バージョン1803 64bitでの動作を確認しています。
　　　Windows7以降のWindowsで起動できるかと思いますが、Windows8以上が推奨となっております。



【３－１．特徴】
　　　①この専ブラには「BOT/マクロ操作」「チート機能」「Flashの抽出」は一切ないです。そんな機能を開発できる能力なんてありません。
　　　②メインウインドウは最低限の機能しかないのでスペースもとりません。
　　　③もちろん画面を展開して広々と使うこともできます。ウインドウ位置は保存されますので再起動しても安心です。



【３－２．技術的(簡易)解説】
　　　ソフトウエア上にありますCefsharpコンポーネントにおいてChromiumと同様に艦これが動作しています。
　　　ウインドウにはページの一部分だけを切り取って表示されていますので、インラインフレームの抽出は行っていません。
　　　その上でHTTP/HTTPSローカルプロキシが艦これのサーバからの「ダウンロード」通信のみを傍受しております。
　　　その中でもJsonデータのみに絞ってメモリ上に一時保存し、それをもとに艦隊情報の表示や制空値の計算を行っております。
　　　詳しくはソースコードに目を通していただけると嬉しいです。



【４．簡単な使い方・機能説明】
　　　①Admiral_s_Desk.exeを起動します。
　　　②ログインします。
　　　③艦これをプレイします。
　　　以上の動作だけで艦これをプレイすることができます。
　　　初回起動時にはルート証明書に関するダイアログが出ますが、これは内蔵するプロキシ(Titanium)に起因するものです。
　　　また、専ブラとしての機能を利用するときは、画面下のチェックボックスにチェックを入れてください。
　　　チェックに応じた各種ウインドウが表示され様々な機能を利用することができます。
　　　さらに、これらのウインドウは前記のチェックを外すことで閉じることができ、不要なときは簡単にしまえるようになっています。


　　　■各ウインドウの簡易解説
　　　　現在実装されているウインドウは以下のとおりです。

　　　　○メインウインドウ・・・・・艦これの画面が表示されているウインドウです。
　　　　　　　　　　　　　　　　　　必要最小限の機能しかないウインドウですが、各機能にアクセスするためのチェックボックスが設置されています。
　　　　　　　　　　　　　　　　　　ここからウインドウ表示/終了操作を行います。

　　　　　　　　　　　　　　　　　　【SS(スクリーンショット)撮影について】
　　　　　　　　　　　　　　　　　　艦これの画面を設定無し・ボタンひと押しで簡単に撮影することができます。
　　　　　　　　　　　　　　　　　　画像は\SS\フォルダ内に作成され、ファイル名は「撮影時間.png」に自動で命名されます。
　　　　　　　　　　　　　　　　　　あくまでお手軽撮影機能ですので、凝った撮影をしたい場合は「艦これ一覧めいかー改二」などの他のスクリーンショットソフトをご利用ください。

　　　　　　　　　　　　　　　　　　【ミュート機能について】
　　　　　　　　　　　　　　　　　　「ミュート」ボタンを押すことで艦これの音量をゼロにすることができます。
　　　　　　　　　　　　　　　　　　また「ミュート解除」のとき押すと音声ありに戻ります。

　　　　○提督情報ウインドウ・・・・提督の情報及び資材・資源量、マップ攻略状態を見ることができます。

　　　　○艦隊情報ウインドウ・・・・艦隊の情報を見ることができます。
　　　　　　　　　　　　　　　　　　分岐点係数の調整に対応した(33)式索敵スコアや制空値などが自動計算されて表示されています。
　　　　　　　　　　　　　　　　　　疲労回復タイマーで疲労抜きに必要な残り時間も知ることができます。

　　　　○遠征情報ウインドウ・・・・遠征に出た艦隊の帰還時刻・残り時間などを見ることができます。

　　　　○工廠情報ウインドウ・・・・入渠・建造・開発の3つについて様々な情報を見ることができます。

　　　　○任務情報ウインドウ・・・・受注した任務についての情報を見ることができます。

　　　　○全艦娘一覧ウインドウ・・・母港にいる全艦娘の情報を一覧として見ることができます。

　　　　○戦闘予報ウインドウ・・・・マップ変更のためこの機能は封印します。

　　　以上全てのウインドウについて、情報を受信するまで空欄となっている・未設定の文字が表示されることがありますが、それは仕様です。

　　　■オプションについて
　　　　メニューバーのツール＞オプションより各種設定を行うことができます。
　　　　現在実装されている設定項目は以下のとおりです。

　　　　○起動時に更新の確認をする・・・ソフトウエア起動時に自動で更新のチェックを行います。

　　　　○ドロップした艦娘の記録・・・・ドロップしたマップやマスを指定したファイルに記録します。
　　　　　（試験的）　　　　　　　　　　記録形式はCSVで、Excelなどで開くことができます。
　　　　　　　　　　　　　　　　　　　　チェックを入れて保存ファイル名を指定した後記録が始まります。
　　　　　　　　　　　　　　　　　　　　なお試験的機能なので不具合が発生する可能性があります。

　　　　○動作速度設定・・・・・・・・・メインウインドウ以外の各ウインドウの更新の頻度の調整ができます。
　　　　　　　　　　　　　　　　　　　　更新の頻度はトラックバーの下に表記されている速度となります。
　　　　　　　　　　　　　　　　　　　　遅くするとCPU/GPUへの負荷が軽減されます（基本的に）。
　　　　　　　　　　　　　　　　　　　　なお、この設定の結果はメインウインドウに影響を及ぼしません。

　　　　○拡大率設定（試験的）・・・・・メインウインドウのブラウザ部分の拡大率を設定できます。

　　　　○大破艦通知設定(戦闘時)・・・・データ更新時に艦隊に大破艦がいるとトースト通知またはバルーン通知で通知されます。
　　　　　　　　　　　　　　　　　　　　通知がしつこいのは仕様です。

　　　　○遠征終了通知設定・・・・・・・遠征が終了したときトースト通知またはバルーン通知で通知されます。

　　　　○疲労回復通知設定・・・・・・・疲労抜きが終わった時トースト通知またはバルーン通知で通知されます。

　　　　○上流プロキシ設定・・・・・・・上流プロキシの設定を行うことができます。
　　　　　　　　　　　　　　　　　　　　誤った内容を入れると艦これの画面が表示されなくなりますのでご注意下さい。




【５．ソフトウエア設定やキャッシュの初期化について】
　　　ウインドウが操作不可能な位置に移動してしまった場合、ソフトウエア設定の初期化を行うと直る場合があります。
　　　設定ファイルはC:\ユーザ\[[ユーザー名]]\AppData\Local\masteralice3104\　＞　"Admiral_s_Desk.exe"より始まるフォルダ　＞　バージョン名が入ったフォルダの中に存在しております。
　　　ファイル名は"user.config"となっておりこのファイルを削除することでソフトウエア設定の初期化を行うことができます。
　　　また、Cefsharpコンポーネントの初期化(キャッシュの初期化)はC:\ユーザ\[[ユーザー名]]\AppData\Local\CEF\のフォルダを消すことによってできます。



【６．Ｑ＆Ａ】
　　　Ｑ：この専ブラを使ったらBANされる？
　　　　　Ａ：現状は大丈夫ですが、将来的にどうなるかわかりません。
　　　　　　　少なくともマクロ・チート機能などはなく、Webブラウザ画面以外からのデータの送信は行わない設計となっております。
　　　　　　　その点を了承の上ご利用ください。

　　　Ｑ：こういう機能がほしい！追加して！
　　　Ｑ：バグをみつけた！なおして！
　　　　　Ａ：この専用ブラウザのTwitter(@Admiral_s_Desk)または作者Twitter(@masteralice3104)までお知らせください。
　　　
　　　Ｑ：スクショや動画を撮りたい
　　　　　Ａ：kanahiron氏作「艦これ一覧めいかー改二」が本ソフトウエア上で動作することを確認しています。
　　　　　　　凝った撮影・動画撮影の際はぜひご利用ください。

　　　Ｑ：このブラウザで課金とかしていいの？
　　　　　Ａ：画面を移動させない仕様により課金画面に（たぶん）たどり着けません。やめましょう。
　　　　　　　また無理やりこの仕様を回避する方法は（一応）存在しますが正しく課金されない可能性もあるので絶対にやめてください。

　　　Ｑ：どのポート使ってるの？
　　　　　Ａ：4297番です。

　　　Ｑ：アンインストールしたいんだけど
　　　　　Ａ：Admiral_s_Desk.exeが入ったフォルダごと削除してください。
　　　　　　　また、完全に削除するためには５．で示されているソフトウエア設定の初期化を行うとゴミがなくなります。
　　　
　　　Ｑ：ソースコードってどこにあるの
　　　　　Ａ：https://github.com/masteralice3104/Admiral-s-desk
　　　　　　　ここにあります。ひどいソースコードですがどうぞ。
　　　　　　　あとみんなC#だと思っているみたいですが実はVB.netです。ほぼ関数の互換性あるしね！

　　　Ｑ：艦これの通信データ形式について解説して
　　　　　Ａ：そのうちやるかもしれません

　　　Ｑ：ソースコードを使って派生ソフトウエアを作っていい？
　　　　　Ａ：チート機能やマクロなど特に厳重に禁止されている行為を行わないソフトである限り、ソースコードは自由に使ってください。
　　　
　　　Ｑ：再配布していい？
　　　　　Ａ：ソフトウエア本体(.exe)の再配布は基本的にはだめです。
　　　　　　　どうしても再配布したい場合は作者へTwitter等で連絡をとり許可を得てください。

　　　Ｑ：実装予定の機能とかはある？
　　　　　Ａ：プラグイン機能を実装したいと思っています。

　　　Ｑ：Do you release English version?
　　　　　Ａ：It is currently under consideration.



【７．更新ログ】

2018/08/19 Admiral's Desk ver 0.2.0.3α
　　　[追加]上流プロキシ設定機能

　　　[追加]ハードウェアアクセラレーションの有無の切替

　　　[修正]画面をアクティブにしたときの挙動

　　　[修正]疲労抜き補助機能のバグ取り

　　　[修正]SS機能復活

　　　[ 他 ]動作の安定性の向上

2018/08/19 Admiral's Desk ver 0.2.0.2α
　　　[対応]bugfix―トースト通知が機能しない

　　　[対応]bugfix―ログイン画面でスクロールしてしまう

　　　[対応]bugfix―全艦娘一覧が表示されない

　　　[追加]疲労抜き補助機能

2018/08/18 Admiral's Desk ver 0.2.0.1α
　　　[対応]bugfix―Cefsharpが暴走するバグ

　　　[変更]プロキシをNekoxyからTitaniumに変更

　　　[対応]66.7%モード搭載

2018/08/18 Admiral's Desk ver 0.2.0.0α
　　　[対応]艦これ2期Block-1への暫定対応

　　　[変更]ブラウザ部分をIE7コンポーネントからCefsharpコンポーネントへ変更

　　　[変更]うまく動作しない部分を一部封印

　　　[バグ]Cefsharpが暴走する模様


2018/08/05 Admiral's Desk ver 0.1.4.0α
　　　[修正]大破艦通知機能の修正(バルーンまたはトースト通知への変更)

　　　[追加]艦これウインドウのスクリーンショット機能を追加

　　　[追加]艦これウインドウのミュート機能を追加

　　　[追加]遠征終了通知機能の追加

2018/05/01 Admiral's Desk ver 0.1.3.2bα
　　　[修正]33式索敵スコア表示欄が正しく表示されない問題の修正

　　　[0.1.3.2b修正]バージョンが間違っていました！すみません！

2018/04/22 Admiral's Desk ver 0.1.3.0α
　　　[修正]全艦娘一覧のウインドウ内容を微修正

　　　[修正]33式索敵スコア表示欄の微修正

　　　[追加]大破艦確認通知機能

　　　[追加]戦闘予報ウインドウの追加
　　　　　　→戦闘前に予想される敵編成などを確認できるようになりました！

2018/04/04 Admiral's Desk ver 0.1.2.0α
　　　[修正]更新確認のデフォルト値をONに変更

　　　[修正]ファイルバージョンが間違っていたのを正しく修正

　　　[追加]任務情報ウインドウ追加
　　　　　　→いつでも受注任務を見ることが可能に

　　　[追加]ドロップした艦娘を記録する機能追加

　　　[追加]全艦娘一覧表示ウインドウ追加
　　　　　　→メインウインドウ右下のボタンよりアクセスできます

2018/04/02 Admiral's Desk ver 0.1.1.0α
　　　[修正]遠征の残り時間表示の不具合修正
　　　　　　→遠征から帰ってくると表示が変わるようになりました

　　　[修正]補給時に情報が更新されないことがある不具合修正

　　　[修正]出撃中の艦隊情報ウインドウが更新可能に
　　　　　　→出撃中でも安心です

　　　[追加]工廠情報ウインドウ追加
　　　　　　→入渠・建造・開発を見ることが可能に

　　　[追加]動作速度設定オプション追加
　　　　　　→ウインドウの更新の頻度を変更することが出来るようになりました

2018/03/31 Admiral's Desk ver 0.1.0.1α
　　　[修正]描画処理の頻度及びタイミングの調整
　　　　　　→GPUへの負荷がかなり減少しました

　　　[修正]アップデート通知に関する機能が実質無機能であったため修正
　　　　　　→これからはきちんとアップデート通知が出るようになります

　　　[修正]分岐点係数入力欄への不正な入力への対策
　　　　　　→数字以外の文字を入力しても問題がないように対策しました

　　　[修正]有効ではないスレッド間の操作が発生しないように調整
　　　　　　→少しだけソフトが落ちづらくなりました

2018/03/29　Admiral's Desk ver0.1.0.0α
　　　ソフトウエア初公開



【８．ライセンス】


< Json.NET >(　←依存：ソフト本体　)

Copyright (c) 2007 James Newton-King

Permission is hereby granted, free of charge, to any person obtaining a copy of this
software and associated documentation files (the "Software"), to deal in the Software
without restriction, including without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be included in all copies
or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


<Titanium Web Proxy>(　←依存：ソフト本体　)

The MIT License (MIT)

Copyright (c) 2015 titanium007

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


< Cefsharp >(　←依存：ソフト本体　)
// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//    * Redistributions of source code must retain the above copyright
//      notice, this list of conditions and the following disclaimer.
//
//    * Redistributions in binary form must reproduce the above
//      copyright notice, this list of conditions and the following disclaimer
//      in the documentation and/or other materials provided with the
//      distribution.
//
//    * Neither the name of Google Inc. nor the name Chromium Embedded
//      Framework nor the name CefSharp nor the names of its contributors
//      may be used to endorse or promote products derived from this software
//      without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
