Thanks for purchasing Modular Research Center.

To make showcase level look correctly, download and import Post Processing Stack to your project (https://www.assetstore.unity3d.com/en/#!/content/83912).
Showcase level was created in Gamma color space(which is used by default, when you create a project). 
If you need Linear color space, use PostProcessingProfileLinear instead of PostProcessingProfileGamma in Scripts folder.
You can change color space in Edit->Project Settings->Player menu.
By default on the level, you can find only static camera, but you can import first person character from Standard Assets and add Post Processing Behaviour Component to the FPC camera to move around the level.
In Camera settings use Deferred Rendering Path with MSAA turn off, HDR turn off.
Use Temporal AA to get the best results (Can be set in Post Processing Profile).