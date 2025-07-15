Frame
=============================================================================

The Frame (`ui::CFrame`) can be thought of as a container for other UI
elements, similar to a window or panel. It sits at the top of the UI
hierarchy and is independent of any other controls.


Usage
-----------------------------------------------------------------------------

Unlike other controls, the Frame control does not have a simple-to-use
creation function, as controls are usually created _on_ a frame, and at
this time we're not aware of any functions that could create a control
outside of an existing frame, be it a Frame or any other control. Given
this restriction, the simplest way to create a Frame is to spawn a clone
of an existing addon frame, remove its children, and build up the custom
frame from there.

**Basic Example**

This example creates a new frame by creating a copy of "postbox_itemget",
a simple frame used in the game, and then modifying its basic properties
to get an empty frame we can use. It uses the default skin used by most
windows in the game and is resized and centered on the screen.

```lua
local frame = ui.CreateNewFrame("postbox_itemget", "FrmExample")
frame:SetSkinName("test_frame_low")
frame:ShowTitleBar(0)
frame:RemoveAllChild()
frame:Resize(500, 400)
frame:SetMargin(0, 0, 0, 0)
```

**Advanced Example**

After creating the basic frame, it's simple to add controls to it, such
as a title bar and a close button to create a proper window. A groupbox
makes up the title bar with the typical blue ribbon background, a text
element displays the title, and a button is used to close the frame.

```lua
local frame = ui.CreateNewFrame("postbox_itemget", "FrmExample")
-- ... (same as above)
frame:EnableHittestFrame(1)
frame:EnableMove(1)

local grpTitle = frame:CreateControl("groupbox", "GrpTitle", 0, 0, frame:GetWidth(), 128)
AUTO_CAST(grpTitle)
grpTitle:EnableHitTest(0)
grpTitle:SetSkinName("test_frame_top")

local txtTitle = grpTitle:CreateControl("richtext", "TxtTitle", 0, 0, frame:GetWidth(), 64)
AUTO_CAST(txtTitle)
txtTitle:SetTextAlign("center", "center")
txtTitle:SetText("{@st42}{s20}Test Window")

function FrmExample_Close()
	ui.CloseFrame("FrmExample")
end

local btnClose = frame:CreateControl("button", "BtnClose", 0, 0, 44, 44)
AUTO_CAST(btnClose)
btnClose:SetGravity(ui.RIGHT, ui.TOP)
btnClose:SetMargin(0, 20,  28, 0)
btnClose:SetImage("testclose_button")
btnClose:SetEventScript(ui.LBUTTONUP, "FrmExample_Close")
```
