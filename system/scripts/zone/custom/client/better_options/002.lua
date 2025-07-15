-- We can technically change the options from the core as well,
-- but some options don't take proper effect until a relog.

-- Disables mercenary badge messages, PC bang timer, and FPS counter
config.ChangeXMLConfig('ShowCoinGetGauge', 0)
config.ChangeXMLConfig('ShowPCBangTimer', 0)
config.ChangeXMLConfig('ShowPerformanceValue', 0)

ui.CloseFrame('pcbang_point_timer');
ui.CloseFrame('fps');
