# TabbedPageSample

Xamarin.Forms + Prism のTabbedPageサンプルです。<br>
TabbedPageの他に以下も使用しています。<br>

* ListView
* DataTemplateSelectorによるListViewの行データによるレイアウト切り替え。
* MenuItemによるListViewの行削除。
* ControlTemplateによるXAMLの部品化。

## 画面遷移図

![画面遷移図](Images/ScreenTransitionDiagram.png)
```plantuml
@startuml

[*] --> MainPage
MainPage --> MyTabbedPage

state MyTabbedPage {
    ContentAPage -r-> ContentBPage
    ContentBPage -l-> ContentAPage
}

ContentAPage --> SubPage

@enduml
```

### MainPage
TabbedPageに遷移する画面。<br>
![MainPage](Images/MainPage.png)

### MyTabbedPage - ContentAPage

TabbedPageのタブ1つ目。<br>
![ContentAPage](Images/ContentAPage.png)

### MyTabbedPage - ContentBPage

TabbedPageのタブ2つ目。<br>
![ContentBPage](Images/ContentBPage.png)
<br>
* DataTemplateSelectorを使って、データにあわせてListViewの行表示・コンテキストメニュー有無を切り替え。
* MenuItemでコンテキストメニューを表示。削除メニューで行を削除。
* ControlTemplateによるXAMLの部品化。背景が薄い群青色のエリアが部品化したエリア。

### SubPage
![SubPage](Images/SubPage.png)

