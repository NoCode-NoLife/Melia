WebPicture
=============================================================================

The WebPicture control (`ui::CWebPicture`) is an image control used to
display images from a URI, be it a local file or a remote URL. In the
case of a URL, the system will download the image and save it to the
game folder, under the `user/url/` directory.


Challenges
-----------------------------------------------------------------------------

While the WebPicture control appears straightforward on the surface, it
doesn't seem to be fully functional in the game, presenting some
challenges in getting it to actually work.

The biggest hurdle is that the control doesn't automatically load the
image it downloaded from a URL. Instead, it requires for the image to be
set manually using a local path after the download is complete. And
unfortunately there's also no way of knowing when or if the download was
completed. The best workaround for this is to load the image in advance,
perhaps when the game first starts, and then use the local path going
forward.

Another issue is that the client primarily loads images from the `banner`
and `loadingimg` directories, which must be present in the path for
images to be loaded into the WebPicture control. This restriction can be
bypassed by using `config.GetLoadingImgURL()`, pointing towards the
`loadingimg` directory, and then navigating backwards relative to that
path using `..\user\url\`.


Usage
-----------------------------------------------------------------------------

The WebPicture control is created like any other control, but can receive
a URL via `SetUrlInfo`. As soon as the URL is set, the control will start
downloading the image if it doesn't exist locally yet. Once the file is
there, it can be set via its local path.

**Basic Example**

```lua
local url = ""https://picsum.photos/640/360.jpg""
local filePath = string.format(""%s..\\user\\url\\%s"", config.GetLoadingImgURL(), url:gsub(""[/:?]"", ""_""))

local imgWeb = frame:CreateOrGetControl(""webpicture"", ""ImgWebTest"", 0, 0, 320, 180)
AUTO_CAST(imgWeb)
imgWeb:SetEnableStretch(1)
imgWeb:SetUrlInfo(url)

-- Later...
imgWeb:SetUrlInfo(filePath)
```

**Delayed Loading Example**

An alternative to preloading an image is to try loading it repeatedly
after the download was initiated, using a timer method such as
`ReserveScript`. In this example we attempt to set the image after a
delay and keep trying until the image was loaded and the control's width
is no longer 0.

```lua
function ImgWebTest_Update(imgWeb, count)
	-- Stop if the image was loaded or we tried too many times
	if imgWeb:GetImageWidth() ~= 0 or count >= 100 then
		Melia.Log.Error(""Failed to load web picture: "" .. url)
		return
	end
	
	-- Set the image with its local path
	imgWeb:SetUrlInfo(filePath)
	
	-- If the image width is still 0, try again after a short delay
	if imgWeb:GetImageWidth() == 0 then
		imgWeb:ReserveScript(""ImgWebTest_Update"", 0.2, count + 1)
	end
end

imgWeb:ReserveScript(""ImgWebTest_Update"", 0, 0)
```
