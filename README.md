# Grand Octet Plugin
This is an ACT plugin that determines who will have the Twintania marker during Grand Octet, and uses TTS to say the name of that player.

Download The Plugin DLL:\
https://github.com/PunishedPineapple/OctetPlugin/releases/latest

## Important:
This is a work in progress, and has not been verified to work correctly during the actual fight.

## Steps:
1. Copy the plugin DLL to the desired location.
2. Add the plugin to ACT.
3. Fill the names of your party members into the list on the plugins tab in ACT.  The order of names does not matter.

The player name list can be exported and imported if necessary.

## How it Works:
Checks for seven total log lines that match the RegEx\
`1B:[0-9A-F]{8}:[\\w'-]+ [\\w'-]+:[0-9A-F]{4}:[0-9A-F]{4}:00(14|29|77):[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F]{4}:`
within 30 seconds of the first.

## Problems:
1. This doesn't account very well for when there's a single dead party member when Octet finishes casting.  You might get a false call in that case.
2. There's probably a way to determine the party member names through the ACT API without having to have a fixed list, but I don't know how and don't want to spend the time to figure it out on my own.  If anyone knows how to easily do this, please let me know, and I will update the plugin.