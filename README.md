# Camera2TransparencyPatch
[Camera2](https://github.com/kinsi55/CS_BeatSaber_Camera2)のEFFECTSのTransparencyで最小でも10%は透過してしまうのを透過させない様にします。

![image](https://user-images.githubusercontent.com/14249877/222939931-9a1f5b3c-62a5-456b-88e7-b1ba2437770c.png)

# インストール方法
1. [リリースページ](https://github.com/rynan4818/Camera2TransparencyPatch/releases)から最新のCamera2TransparencyPatchのリリースをダウンロードします。
2. ダウンロードしたzipファイルを`Beat Saber`フォルダに解凍して、`Plugin`フォルダに`Camera2TransparencyPatch.dll`ファイルをコピーします。

※対象のCamera2はv0.6.99とv0.6.100です。([次のバージョンアップで対応される見込み](https://github.com/kinsi55/CS_BeatSaber_Camera2/issues/98))

# 注意点
Camera2の`LuminanceKey.shader`を差し替えるため将来的にCamera2の更新で挙動がおかしくなる可能性があります。[LuminanceKey.shaderの変更履歴](https://github.com/kinsi55/CS_BeatSaber_Camera2/commits/master/Shaders/LuminanceKey.shader)で最新のコミットが本modのリリース日より新しくなっている場合は使用を控えて下さい。

# mod制作の参考
ソースコードの`LuminanceKey.shader`と、そのAssetBundleの`custom_luminancekey`は、[Camera2](https://github.com/kinsi55/CS_BeatSaber_Camera2)の[LuminanceKey.shader](https://github.com/kinsi55/CS_BeatSaber_Camera2/blob/master/Shaders/LuminanceKey.shader)をコピーしています。

Camera2の著作・ライセンスは以下です。

[Canera2 LICENSE](https://github.com/rynan4818/Camera2TransparencyPatch/blob/main/Camera2_LICENSE)
