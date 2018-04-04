■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

　　　　　　「艦隊これくしょん－艦これ－」専用ブラウザ
　　　　　　　　Admiral's Desk ver0.1.1.0α ReadMe

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

　　　2018年度の艦これ1期→2期への移行については順次仕様変更へ対応する予定ですが、データ形式・通信方式の変更などで深刻なバグが発生する可能性があります。十分注意の上ご利用ください。



【１．コンセプト・概要】
　　　「艦これをプレイする時、専ブラって情報量が多い！」と感じた作者が「必要な時、必要なだけ」情報を表示できるようにと思い作った専用ブラウザです。
　　　ながらプレイする用途から海域攻略まで全てをこれ一つで賄えるようなブラウザを目指して開発中です。



【２．インストール・動作環境について】
　　　インストールの方法は、お好きな場所に"Admiral_s_Desk"フォルダを解凍するだけです。

　　　起動には.NET Framework 4.6.1が必要です。
　　　起動できなかった場合はインストールされているかどうかを確認してください。
　　　
　　　Windows10　バージョン1709での動作を確認しています。
　　　Windows7以降のWindowsで起動できるかと思います。



【３－１．特徴】
　　　①この専ブラには「BOT/マクロ操作」「チート機能」は一切ないです。そんな機能を開発できる能力なんてありません。
　　　②メインウインドウは最低限の機能しかないのでスペースもとりません。
　　　③もちろん画面を展開して広々と使うこともできます。ウインドウ位置は保存されますので再起動しても安心です。



【３－２．技術的(簡易)解説】
　　　ソフトウエア上にありますWebbrowserコントロールにてIEと同様に艦これが動作しています。
　　　その上でHTTPローカルプロキシが艦これのサーバからの「ダウンロード」通信のみを傍受しております。
　　　その中でもJsonデータのみに絞ってメモリ上に一時保存し、それをもとに艦隊情報の表示や制空値の計算を行っております。
　　　詳しくはソースコードに目を通していただけると嬉しいです。



【４．簡単な使い方・機能説明】
　　　①Admiral_s_Desk.exeを起動します。
　　　②艦これにログインします。IEや他の専用ブラウザで艦これにログインしていた場合などは、この動作は不要となる場合があります。
　　　③艦これをプレイします。
　　　以上の動作だけで艦これをプレイすることができます。
　　　また、専ブラとしての機能を利用するときは、画面下のチェックボックスにチェックを入れてください。
　　　チェックに応じた各種ウインドウが表示され様々な機能を利用することができます。
　　　さらに、これらのウインドウは前記のチェックを外すことで閉じることができ、不要なときは簡単にしまえるようになっています。


　　　■各ウインドウの簡易解説
　　　　現在実装されているウインドウは以下のとおりです。

　　　　○メインウインドウ・・・・艦これの画面が表示されているウインドウです。
　　　　　　　　　　　　　　　　　必要最小限の機能しかないウインドウですが、各機能にアクセスするためのチェックボックスが設置されています。
　　　　　　　　　　　　　　　　　ここからウインドウ表示/終了操作を行います。

　　　　○提督情報ウインドウ・・・提督の情報及び資材・資源量、マップ攻略状態を見ることができます。

　　　　○艦隊情報ウインドウ・・・艦隊の情報を見ることができます。
　　　　　　　　　　　　　　　　　分岐点係数の調整に対応した(33)式索敵スコアや制空値などが自動計算されて表示されています。

　　　　○遠征情報ウインドウ・・・遠征に出た艦隊の帰還時刻・残り時間などを見ることができます。

　　　　○工廠情報ウインドウ・・・入渠・建造・開発の3つについて様々な情報を見ることができます。

　　　　○任務情報ウインドウ・・・受注した任務についての情報を見ることができます。

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
　　　　　　　　　　　　　　　　　　　　遅くするとCPU/GPUへの負荷が軽減されます。
　　　　　　　　　　　　　　　　　　　　なお、この設定の結果はメインウインドウに影響を及ぼしません。



【５．ソフトウエア設定の初期化について】
　　　ウインドウが操作不可能な位置に移動してしまった場合、ソフトウエア設定の初期化を行うと直る場合があります。
　　　設定ファイルはC:\ユーザ\[[ユーザー名]]\AppData\Local\masteralice3104\　＞　"Admiral_s_Desk.exe"より始まるフォルダ　＞　バージョン名が入ったフォルダの中に存在しております。
　　　ファイル名は"user.config"となっておりこのファイルを削除することでソフトウエア設定の初期化を行うことができます。



【６．Ｑ＆Ａ】
　　　Ｑ：この専ブラを使ったらBANされる？
　　　　　Ａ：現状は大丈夫ですが、将来的にどうなるかわかりません。
　　　　　　　少なくともマクロ・チート機能などはなく、Webブラウザ画面以外からのデータの送信は行わない設計となっております。
　　　　　　　その点を了承の上ご利用ください。

　　　Ｑ：こういう機能がほしい！
　　　Ｑ：バグをみつけた！
　　　　　Ａ：この専用ブラウザのTwitter(@Admiral_s_Desk)または作者Twitter(@masteralice3104)までお知らせください。
　　　
　　　Ｑ：スクショや動画を撮りたい
　　　　　Ａ：kanahiron氏作「艦これ一覧めいかー改二」が本ソフトウエア上で動作することを確認しています。
　　　　　　　撮影の際はぜひご利用ください。

　　　Ｑ：アンインストールしたいんだけど
　　　　　Ａ：Admiral_s_Desk.exeが入ったフォルダごと削除してください。
　　　　　　　また、完全に削除するためには５．で示されているソフトウエア設定の初期化を行うとゴミがなくなります。
　　　
　　　Ｑ：ソースコードってどこにあるの
　　　　　Ａ：https://github.com/masteralice3104/Admiral-s-desk
　　　　　　　ここにあります。ひどいソースコードですがどうぞ。

　　　Ｑ：艦これの通信データ形式について解説して
　　　　　Ａ：そのうちやるかもしれません

　　　Ｑ：ソースコードを使って派生ソフトウエアを作っていい？
　　　　　Ａ：チート機能やマクロなど特に厳重に禁止されている行為を行わないソフトである限り、ソースコードは自由に使ってください。
　　　
　　　Ｑ：再配布していい？
　　　　　Ａ：ソフトウエアの再配布はだめです。

　　　Ｑ：実装予定の機能とかはある？
　　　　　Ａ：プラグイン機能を実装したいと思っています。

　　　Ｑ：艦これ2期への対策はしているの？
　　　　　Ａ：一度データ形式を変換してから読み込んでいるので通信方式の変更などがなければ対応できると思います。
　　　　　　　また解像度変更対策を早めに講じる予定です。
　


【７．更新ログ】

2018/04/04 Admiral's Desk ver 0.1.2.0α
　　　[修正]更新確認のデフォルト値をONに変更

　　　[修正]ファイルバージョンが間違っていたのを正しく修正

　　　[追加]任務情報ウインドウ追加
　　　　　　→いつでも受注任務を見ることが可能に

　　　[追加]ドロップした艦娘を記録する機能追加

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

< Nekoxy >(　←依存：ソフト本体　)

The MIT License (MIT)

Copyright (c) 2015 veigr

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

< TrotiNet > (　←依存：Nekoxy　) (ソースコードはgithubのNekoxy-master.zip)

Copyright (c) TrotiNet Team 2011-2013


                   GNU LESSER GENERAL PUBLIC LICENSE
                       Version 3, 29 June 2007

 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.


  This version of the GNU Lesser General Public License incorporates
the terms and conditions of version 3 of the GNU General Public
License, supplemented by the additional permissions listed below.

  0. Additional Definitions.

  As used herein, "this License" refers to version 3 of the GNU Lesser
General Public License, and the "GNU GPL" refers to version 3 of the GNU
General Public License.

  "The Library" refers to a covered work governed by this License,
other than an Application or a Combined Work as defined below.

  An "Application" is any work that makes use of an interface provided
by the Library, but which is not otherwise based on the Library.
Defining a subclass of a class defined by the Library is deemed a mode
of using an interface provided by the Library.

  A "Combined Work" is a work produced by combining or linking an
Application with the Library.  The particular version of the Library
with which the Combined Work was made is also called the "Linked
Version".

  The "Minimal Corresponding Source" for a Combined Work means the
Corresponding Source for the Combined Work, excluding any source code
for portions of the Combined Work that, considered in isolation, are
based on the Application, and not on the Linked Version.

  The "Corresponding Application Code" for a Combined Work means the
object code and/or source code for the Application, including any data
and utility programs needed for reproducing the Combined Work from the
Application, but excluding the System Libraries of the Combined Work.

  1. Exception to Section 3 of the GNU GPL.

  You may convey a covered work under sections 3 and 4 of this License
without being bound by section 3 of the GNU GPL.

  2. Conveying Modified Versions.

  If you modify a copy of the Library, and, in your modifications, a
facility refers to a function or data to be supplied by an Application
that uses the facility (other than as an argument passed when the
facility is invoked), then you may convey a copy of the modified
version:

   a) under this License, provided that you make a good faith effort to
   ensure that, in the event an Application does not supply the
   function or data, the facility still operates, and performs
   whatever part of its purpose remains meaningful, or

   b) under the GNU GPL, with none of the additional permissions of
   this License applicable to that copy.

  3. Object Code Incorporating Material from Library Header Files.

  The object code form of an Application may incorporate material from
a header file that is part of the Library.  You may convey such object
code under terms of your choice, provided that, if the incorporated
material is not limited to numerical parameters, data structure
layouts and accessors, or small macros, inline functions and templates
(ten or fewer lines in length), you do both of the following:

   a) Give prominent notice with each copy of the object code that the
   Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the object code with a copy of the GNU GPL and this license
   document.

  4. Combined Works.

  You may convey a Combined Work under terms of your choice that,
taken together, effectively do not restrict modification of the
portions of the Library contained in the Combined Work and reverse
engineering for debugging such modifications, if you also do each of
the following:

   a) Give prominent notice with each copy of the Combined Work that
   the Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the Combined Work with a copy of the GNU GPL and this license
   document.

   c) For a Combined Work that displays copyright notices during
   execution, include the copyright notice for the Library among
   these notices, as well as a reference directing the user to the
   copies of the GNU GPL and this license document.

   d) Do one of the following:

       0) Convey the Minimal Corresponding Source under the terms of this
       License, and the Corresponding Application Code in a form
       suitable for, and under terms that permit, the user to
       recombine or relink the Application with a modified version of
       the Linked Version to produce a modified Combined Work, in the
       manner specified by section 6 of the GNU GPL for conveying
       Corresponding Source.

       1) Use a suitable shared library mechanism for linking with the
       Library.  A suitable mechanism is one that (a) uses at run time
       a copy of the Library already present on the user's computer
       system, and (b) will operate properly with a modified version
       of the Library that is interface-compatible with the Linked
       Version.

   e) Provide Installation Information, but only if you would otherwise
   be required to provide such information under section 6 of the
   GNU GPL, and only to the extent that such information is
   necessary to install and execute a modified version of the
   Combined Work produced by recombining or relinking the
   Application with a modified version of the Linked Version. (If
   you use option 4d0, the Installation Information must accompany
   the Minimal Corresponding Source and Corresponding Application
   Code. If you use option 4d1, you must provide the Installation
   Information in the manner specified by section 6 of the GNU GPL
   for conveying Corresponding Source.)

  5. Combined Libraries.

  You may place library facilities that are a work based on the
Library side by side in a single library together with other library
facilities that are not Applications and are not covered by this
License, and convey such a combined library under terms of your
choice, if you do both of the following:

   a) Accompany the combined library with a copy of the same work based
   on the Library, uncombined with any other library facilities,
   conveyed under the terms of this License.

   b) Give prominent notice with the combined library that part of it
   is a work based on the Library, and explaining where to find the
   accompanying uncombined form of the same work.

  6. Revised Versions of the GNU Lesser General Public License.

  The Free Software Foundation may publish revised and/or new versions
of the GNU Lesser General Public License from time to time. Such new
versions will be similar in spirit to the present version, but may
differ in detail to address new problems or concerns.

  Each version is given a distinguishing version number. If the
Library as you received it specifies that a certain numbered version
of the GNU Lesser General Public License "or any later version"
applies to it, you have the option of following the terms and
conditions either of that published version or of any later version
published by the Free Software Foundation. If the Library as you
received it does not specify a version number of the GNU Lesser
General Public License, you may choose any version of the GNU Lesser
General Public License ever published by the Free Software Foundation.

  If the Library as you received it specifies that a proxy can decide
whether future versions of the GNU Lesser General Public License shall
apply, that proxy's public statement of acceptance of any version is
permanent authorization for you to choose that version for the
Library.

< Apache log4net>(　←依存：TrotiNet　)

﻿
                                 Apache License
                           Version 2.0, January 2004
                        http://www.apache.org/licenses/

   TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION

   1. Definitions.

      "License" shall mean the terms and conditions for use, reproduction,
      and distribution as defined by Sections 1 through 9 of this document.

      "Licensor" shall mean the copyright owner or entity authorized by
      the copyright owner that is granting the License.

      "Legal Entity" shall mean the union of the acting entity and all
      other entities that control, are controlled by, or are under common
      control with that entity. For the purposes of this definition,
      "control" means (i) the power, direct or indirect, to cause the
      direction or management of such entity, whether by contract or
      otherwise, or (ii) ownership of fifty percent (50%) or more of the
      outstanding shares, or (iii) beneficial ownership of such entity.

      "You" (or "Your") shall mean an individual or Legal Entity
      exercising permissions granted by this License.

      "Source" form shall mean the preferred form for making modifications,
      including but not limited to software source code, documentation
      source, and configuration files.

      "Object" form shall mean any form resulting from mechanical
      transformation or translation of a Source form, including but
      not limited to compiled object code, generated documentation,
      and conversions to other media types.

      "Work" shall mean the work of authorship, whether in Source or
      Object form, made available under the License, as indicated by a
      copyright notice that is included in or attached to the work
      (an example is provided in the Appendix below).

      "Derivative Works" shall mean any work, whether in Source or Object
      form, that is based on (or derived from) the Work and for which the
      editorial revisions, annotations, elaborations, or other modifications
      represent, as a whole, an original work of authorship. For the purposes
      of this License, Derivative Works shall not include works that remain
      separable from, or merely link (or bind by name) to the interfaces of,
      the Work and Derivative Works thereof.

      "Contribution" shall mean any work of authorship, including
      the original version of the Work and any modifications or additions
      to that Work or Derivative Works thereof, that is intentionally
      submitted to Licensor for inclusion in the Work by the copyright owner
      or by an individual or Legal Entity authorized to submit on behalf of
      the copyright owner. For the purposes of this definition, "submitted"
      means any form of electronic, verbal, or written communication sent
      to the Licensor or its representatives, including but not limited to
      communication on electronic mailing lists, source code control systems,
      and issue tracking systems that are managed by, or on behalf of, the
      Licensor for the purpose of discussing and improving the Work, but
      excluding communication that is conspicuously marked or otherwise
      designated in writing by the copyright owner as "Not a Contribution."

      "Contributor" shall mean Licensor and any individual or Legal Entity
      on behalf of whom a Contribution has been received by Licensor and
      subsequently incorporated within the Work.

   2. Grant of Copyright License. Subject to the terms and conditions of
      this License, each Contributor hereby grants to You a perpetual,
      worldwide, non-exclusive, no-charge, royalty-free, irrevocable
      copyright license to reproduce, prepare Derivative Works of,
      publicly display, publicly perform, sublicense, and distribute the
      Work and such Derivative Works in Source or Object form.

   3. Grant of Patent License. Subject to the terms and conditions of
      this License, each Contributor hereby grants to You a perpetual,
      worldwide, non-exclusive, no-charge, royalty-free, irrevocable
      (except as stated in this section) patent license to make, have made,
      use, offer to sell, sell, import, and otherwise transfer the Work,
      where such license applies only to those patent claims licensable
      by such Contributor that are necessarily infringed by their
      Contribution(s) alone or by combination of their Contribution(s)
      with the Work to which such Contribution(s) was submitted. If You
      institute patent litigation against any entity (including a
      cross-claim or counterclaim in a lawsuit) alleging that the Work
      or a Contribution incorporated within the Work constitutes direct
      or contributory patent infringement, then any patent licenses
      granted to You under this License for that Work shall terminate
      as of the date such litigation is filed.

   4. Redistribution. You may reproduce and distribute copies of the
      Work or Derivative Works thereof in any medium, with or without
      modifications, and in Source or Object form, provided that You
      meet the following conditions:

      (a) You must give any other recipients of the Work or
          Derivative Works a copy of this License; and

      (b) You must cause any modified files to carry prominent notices
          stating that You changed the files; and

      (c) You must retain, in the Source form of any Derivative Works
          that You distribute, all copyright, patent, trademark, and
          attribution notices from the Source form of the Work,
          excluding those notices that do not pertain to any part of
          the Derivative Works; and

      (d) If the Work includes a "NOTICE" text file as part of its
          distribution, then any Derivative Works that You distribute must
          include a readable copy of the attribution notices contained
          within such NOTICE file, excluding those notices that do not
          pertain to any part of the Derivative Works, in at least one
          of the following places: within a NOTICE text file distributed
          as part of the Derivative Works; within the Source form or
          documentation, if provided along with the Derivative Works; or,
          within a display generated by the Derivative Works, if and
          wherever such third-party notices normally appear. The contents
          of the NOTICE file are for informational purposes only and
          do not modify the License. You may add Your own attribution
          notices within Derivative Works that You distribute, alongside
          or as an addendum to the NOTICE text from the Work, provided
          that such additional attribution notices cannot be construed
          as modifying the License.

      You may add Your own copyright statement to Your modifications and
      may provide additional or different license terms and conditions
      for use, reproduction, or distribution of Your modifications, or
      for any such Derivative Works as a whole, provided Your use,
      reproduction, and distribution of the Work otherwise complies with
      the conditions stated in this License.

   5. Submission of Contributions. Unless You explicitly state otherwise,
      any Contribution intentionally submitted for inclusion in the Work
      by You to the Licensor shall be under the terms and conditions of
      this License, without any additional terms or conditions.
      Notwithstanding the above, nothing herein shall supersede or modify
      the terms of any separate license agreement you may have executed
      with Licensor regarding such Contributions.

   6. Trademarks. This License does not grant permission to use the trade
      names, trademarks, service marks, or product names of the Licensor,
      except as required for reasonable and customary use in describing the
      origin of the Work and reproducing the content of the NOTICE file.

   7. Disclaimer of Warranty. Unless required by applicable law or
      agreed to in writing, Licensor provides the Work (and each
      Contributor provides its Contributions) on an "AS IS" BASIS,
      WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
      implied, including, without limitation, any warranties or conditions
      of TITLE, NON-INFRINGEMENT, MERCHANTABILITY, or FITNESS FOR A
      PARTICULAR PURPOSE. You are solely responsible for determining the
      appropriateness of using or redistributing the Work and assume any
      risks associated with Your exercise of permissions under this License.

   8. Limitation of Liability. In no event and under no legal theory,
      whether in tort (including negligence), contract, or otherwise,
      unless required by applicable law (such as deliberate and grossly
      negligent acts) or agreed to in writing, shall any Contributor be
      liable to You for damages, including any direct, indirect, special,
      incidental, or consequential damages of any character arising as a
      result of this License or out of the use or inability to use the
      Work (including but not limited to damages for loss of goodwill,
      work stoppage, computer failure or malfunction, or any and all
      other commercial damages or losses), even if such Contributor
      has been advised of the possibility of such damages.

   9. Accepting Warranty or Additional Liability. While redistributing
      the Work or Derivative Works thereof, You may choose to offer,
      and charge a fee for, acceptance of support, warranty, indemnity,
      or other liability obligations and/or rights consistent with this
      License. However, in accepting such obligations, You may act only
      on Your own behalf and on Your sole responsibility, not on behalf
      of any other Contributor, and only if You agree to indemnify,
      defend, and hold each Contributor harmless for any liability
      incurred by, or claims asserted against, such Contributor by reason
      of your accepting any such warranty or additional liability.

   END OF TERMS AND CONDITIONS

   APPENDIX: How to apply the Apache License to your work.

      To apply the Apache License to your work, attach the following
      boilerplate notice, with the fields enclosed by brackets "[]"
      replaced with your own identifying information. (Don't include
      the brackets!)  The text should be enclosed in the appropriate
      comment syntax for the file format. We also recommend that a
      file or class name and description of purpose be included on the
      same "printed page" as the copyright notice for easier
      identification within third-party archives.

   Copyright [yyyy] [name of copyright owner]

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.


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

