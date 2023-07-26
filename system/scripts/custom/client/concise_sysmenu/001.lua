Melia.Ui.SysMenu.SuspendRefresh()

Melia.Ui.SysMenu.RemoveButton("BtnCollection")
Melia.Ui.SysMenu.RemoveButton("BtnInstantDungeon")
Melia.Ui.SysMenu.RemoveButton("BtnParty")
Melia.Ui.SysMenu.RemoveButton("BtnAdvancement")
Melia.Ui.SysMenu.RemoveButton("BtnFishing")
Melia.Ui.SysMenu.RemoveButton("BtnGuildPromo")
Melia.Ui.SysMenu.RemoveButton("BtnPcBang")
Melia.Ui.SysMenu.InsertButton(2, "BtnAdvancement", "sysmenu_jobinfo", DicID("UI_20180208_003013"), "OPEN_RANKROLLBACK_UI_BY_SYSMENU()")
Melia.Ui.SysMenu.InsertButton(6, "BtnParty", "sysmenu_party", DicID("UI_20220204_005169"), "ui.ToggleFrame('party')")

Melia.Ui.SysMenu.ResumeRefresh()
