local function RemoveElement(name, frame, child)
	local frm = ui.GetFrame(frame)
	if frm == nil then
		Melia.Log.Warning("Unclutter: Frame '{0}' not found", frame)
		return
	end

	local child = GET_CHILD_RECURSIVELY(frm, child, "ui::CControl")
	if child then
		child:GetParent():RemoveChild(child:GetName())
	end
end

-- Around Minimap
RemoveElement("Open Shops", "minimized_total_shop_button", "openTotalShopBtn")
RemoveElement("TP Shop", "minimized_tp_button", "openTPshopBtn")
RemoveElement("Open Boards", "minimized_total_board_button", "openTotalBoardBtn")
RemoveElement("Open Party", "minimized_total_party_button", "openTotalPartyBtn")
RemoveElement("Grow Up", "minimized_guidequest_button", "openBtn")
RemoveElement("TP", "openingameshopbtn", "open_openingameshopbtn")
RemoveElement("Popo Boost", "minimized_popoboost_2023", "openPoPoBoost")
RemoveElement("Popo Boost Notice", "minimized_popoboost_2023", "notice_bg")
RemoveElement("Fullscreen Menu", "minimized_fullscreen_navigation_menu_button", "btn_open")
RemoveElement("Fullscreen Menu", "minimized_fullscreen_navigation_menu_button", "text_name")
RemoveElement("Invite Your Friends Event", "minimized_friend", "openFriend")
RemoveElement("Invite Your Friends Event", "minimized_friend", "notice_bg")

-- Character Info
RemoveElement("Reset Stat", "status", "status_reset_btn")
