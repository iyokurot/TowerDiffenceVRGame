TowerDiffenceVR

・CardBoardを用いたスマートフォン上でのタワーディフェンス型VRゲーム。


＊開発環境＊＊＊＊＊＊＊＊＊＊＊＊
　・Unity、C#


＊遊び方＊＊＊＊＊＊＊＊＊＊＊＊＊
　・スマートフォン端末にアプリをダウンロード

　・タイトル画面でのスタートボタンタップ後、GoogleCardBoard等を利用し、端末上でVRを見る環境とする。

　・VR上で表示されたボタンを見つめることでモード選択を行う。

　・モードを２種類存在し以下に記す。

　・１：ノーマルモード
　　・次々と現れ迫ってくる敵をプレイヤーが周囲を見渡し、連続的に発射されている弾によって倒す。
　　・１０体倒すことでクリアとなる。
　　・敵がプレイヤーに衝突することでゲームオーバーとなる。
　　・プレイヤーの視点右上に残りの敵数が表示される。

　・２：エンドレスモード
　　・基本操作はノーマルモードと同一であるが、このモードでは出現敵数に限りがなく、プレイヤーがゲームオーバーとなるまで続く。
　　・また、倒した敵数はハイスコアのみが保存され、モード選択画面にてハイスコアが表示される。
　　・プレイヤーの視点右上に現在倒した敵数が表示される。

　・どちらのモードもクリア、ゲームオーバーした際には、リトライボタンとトップボタンの２つが表示され、リトライボタンは再度同じモードをプレイ、トップボタンはタイトル画面へと戻る。


＊使用素材＊＊＊＊＊＊＊＊＊＊＊＊＊
　CardBoard環境の構築
　・GoogleVRSDK

　背景画像の使用
　・Real Stars SkyBox
　　制作者：GEOFF DALLIMORE
　　URL:https://assetstore.unity.com/packages/3d/environments/sci-fi/real-stars-skybox-116333

　銃のモデルの使用
　・Sci-Fi Gun
　　制作者：GRASBOCK
　　URL:https://assetstore.unity.com/packages/3d/sci-fi-gun-30826

　敵モデル、ステージでのテクスチャの使用
　・Ball Pack
　　制作者：YOUNGEN TECH
　　URL：https://assetstore.unity.com/packages/3d/props/ball-pack-446

