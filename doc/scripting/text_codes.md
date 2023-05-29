Text Codes
=============================================================================

The client supports various codes in most textx, like in chat or
NPC dialogues. This is a list of some known codes.

## Reset Formatting

Resets some formatting, but not color or size.

```text
{/}
```

## New Paragraph

Continues NPC dialog on another page, the NPC's name stays the same.

```text
{np}
```

## New Line

A line break.

```text
{nl}
```

## Size

Changes the text's size, with the number being the size.

```text
{s35}
```

## Image

Displays in-line image.

```text
{img ...}
```
Examples:
```text
{img minimap_1_MAIN 16 16}
{img icon_item_silver 20 20}
```

## Script Argument Message

Presumably a reference to clientmessage.xml, with "..." being the key.

```text
!@#ScpArgMsg$...#@!
```

## Bold

Everything that follows is bold. Seemingly stopped working in i171032.

```text
{b}
```

## Italic

Everything that follows is italic.

```text
{i}
```

## Outline

Text gets a black outline.

```text
{ol}
```

## Drop Shadow

Text gets a black drop shadow.

```text
{ds}
```

## Gradation

TODO

```text
{gr gradation2}
```

## Color

Changes text color. Default dialog color appears to be #111111.

```text
{#hex}
```

## Speed

Changes the text speed.

```text
{spd50}
```

## Space

Inserts blank inline space.

```text
{spc20}
```

## Style

Displays following text in a pre-defined style.

```text
{@st41}
```
A few known styles:
- 41: Silver, outline, drop shadow
- 43: Big, silver, outline, drop shadow
- 44: Big, silver, outline
- 45: Big, black
- 46: Big, silver with outline, drop shadow
- 47: Big, red with outline, drop shadow
- 48: Small, silver, outline, drop shadow
- 49: Very small, silver, outline, drop shadow
- 50: Very small, yellow, outline, drop shadow
- 51: Very small, light gray
- 52: Very small, light gray, outline, drop shadow
- 53: Big, brown, outline, drop shadow
- 54: Brown, outline
- 55: Big, italic, brown, outline, drop shadow

## Toggle PC Macro Condition

If used in a dialog, the text following this code doesn't start until
the player clicks or presses space to advance the dialog.

```text
{a TOGGLE_PCMACRO_COND}
```
