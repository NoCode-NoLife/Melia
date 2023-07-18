-- Create system button to toggle buy-in shop creation window.
Melia.Ui.SysMenu.AddButton("BtnBuyInShop", "sysmenu_wugushi", "Create Buy-in Shop", "M_TOGGLE_PERSONAL_SHOP()")

function M_TOGGLE_PERSONAL_SHOP()

	local frame = ui.GetFrame("personal_shop_register")
	if frame:IsVisible() == 1 then
		frame:ShowWindow(false)
	else
		OPEN_PERSONAL_SHOP_REGISTER()
	end
	
end
