-- Create system button to toggle buy-in shop creation window.
local frame = ui.GetFrame("sysmenu")

frame:RemoveChild("BuyInShopBtn")

local otherBtn = frame:GetChild("pcbang_shop")
local margin = otherBtn:GetMargin();

local shopBtn = frame:CreateControl("button", "BuyInShopBtn", 0, 0, 38, 44)
shopBtn:CloneFrom(otherBtn)
AUTO_CAST(shopBtn)

shopBtn:SetMargin(0, 0, margin.right + 38, 10)
shopBtn:SetImage("sysmenu_wugushi")
shopBtn:SetTextTooltip("{@st59}Create Buy-in Shop");
shopBtn:SetEventScript(ui.LBUTTONUP, "M_TOGGLE_PERSONAL_SHOP()", true);

function M_TOGGLE_PERSONAL_SHOP()

	local frame = ui.GetFrame("personal_shop_register")
	if frame:IsVisible() == 1 then
		frame:ShowWindow(false)
	else
		OPEN_PERSONAL_SHOP_REGISTER()
	end
	
end
