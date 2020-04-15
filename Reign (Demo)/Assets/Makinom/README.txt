
Makinom
http://makinom.com


-------------------------------------------------------------------------------------------------------------------------------------------------------
Content
-------------------------------------------------------------------------------------------------------------------------------------------------------

- General Information
- Editor and Scene Wizard
- Tutorials
- Support
- Documentation
- Demo
- Package Description
- iOS Hints
- Makinom Version Changelog



-------------------------------------------------------------------------------------------------------------------------------------------------------
General Information
-------------------------------------------------------------------------------------------------------------------------------------------------------

- DLL information
Makinom is included in your Unity project using DLLs.
This will dramatically decrease your project's compile time if you change any of your own scripts.
The source code for gameplay related code is included - see the 'Package Description' section for details.

- Makinom Project asset
When you first open the Makinom editor, a new Makinom Project asset will be created.
This asset will contain all your Makinom settings made in the editor.
It's located at 'Assets/Makinom/Project.asset'.
You can have multiple Makinom Project assets in your project, the editor will remember the last opened project.

- Schematic assets
When you create schematics, each schematic is stored in a separate asset file.
You can save the schematic assets anywhere in your Unity project.
To keep things organized, it's recommended to create a folder structure mirroring the purpose of the schematics or scenes they're used in.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Editor and Scene Wizard
-------------------------------------------------------------------------------------------------------------------------------------------------------

- Makinom editor
In Makinom you'll create your game's data and game mechanics in the Makinom editor.
You can open the editor using Unity's menu: Window > Makinom.
You can also open the editor using the hot-key 'CTRL + ALT + O'.

The editor is separated into different sections, each section contains multiple sub-sections.
When saving, the editor will display what will change and, depending on what's been changed, offers to update events, scenes and prefabs.
When scenes are updated, please make sure to save your current scene first.

- Makinom Scene Wizard
The Makinom Scene Wizard is used to add your data to your scenes to create gameplay.
You can open the scene wizard using Unity's menu: Window > Makinom Scene Wizard.
You can also open the scene wizard using the hot-key 'CTRL + ALT + W'.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Tutorials
-------------------------------------------------------------------------------------------------------------------------------------------------------

You can find different types of tutorials here:
http://makinom.com/tutorials/

It's recommended to start with one of the game tutorial series, e.g. the Space Shooter:
http://makinom.com/tutorials/space-shooter/

If you're seeking information/help with a specific feature, take a look at the how-tos:
http://makinom.com/tutorials/howtos/

If you have any tutorial requests, don't hesitate and contact me:
contact@makinom.com



-------------------------------------------------------------------------------------------------------------------------------------------------------
Support
-------------------------------------------------------------------------------------------------------------------------------------------------------

Need help or found a bug?

Please search for a solution in the 'Support & Community' forum, or post your problem to get answers:
http://forum.makinom.com/

Didn't find anything? Contact me:
contact@makinom.com



-------------------------------------------------------------------------------------------------------------------------------------------------------
Documentation
-------------------------------------------------------------------------------------------------------------------------------------------------------

The documentation is built into the Makinom editor.
All settings are explained in the help window at the lower left corner of the Makinom editor.

Information and help texts will be displayed if you hover with the mouse over a setting or foldout.
You can change this behaviour in the editor settings (Editor > Editor Settings).

There currently is no separate documentation available.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Demo
-------------------------------------------------------------------------------------------------------------------------------------------------------

You can find complete Unity demo projects here:
http://makinom.com/showcase/



-------------------------------------------------------------------------------------------------------------------------------------------------------
Package Description
-------------------------------------------------------------------------------------------------------------------------------------------------------

- Gizmos (folder)
Contains the gizmo icons (48x48) used by Makinom.

- DLL (folder)
3 DLLs containing Makinom.

- gameplay_source_code.zip
Contains the gameplay related source code and a plugin template as MonoDevelop projects.
Please read the included README.txt for details.
There currently is no separate documentation available.



-------------------------------------------------------------------------------------------------------------------------------------------------------
iOS Hints
-------------------------------------------------------------------------------------------------------------------------------------------------------

If you're building your project for iOS, you may run into some problems:

- Crash after splash screen: "You are using Unity iPhone Basic. You are not allowed to remove the Unity splash screen from your game"
To fix this, change in XCode's build settings the 'Compress PNG files' setting to NO and build the project again.

- Crash after splash screen: "Ran out of trampolines of type 2"
This is caused by use of generics, you have to tell the AOT compiler allocate more trampolines.
To fix this, change in Unity's Player Settings > Other Settings the 'AOT Compiler Options' to nimt-trampolines=512.
If you're still receiving a trampoline error, increase the number, e.g. 1024.

- Crash/stop after or before splash screen: 'EXC_BAD_ACCESS'
This can be caused by Unity engine code being stripped when using 'IL2CPP' scripting backend.
To fix this, disable 'Strip Engine Code' in Unity's PlayerSettings > Other Settings in your iOS player settings.

- Using the new UI and content is displayed outside of masks (e.g. text extends outside of GUI box).
Go to 'Edit > Project Settings > Player' and enable 'Use 24-bit Depth Buffer' in the iOS 'Resolution and Presentation' settings.


You can find more detailed instructions on the Unity trouble shooting page:

http://docs.unity3d.com/Manual/TroubleShootingIPhone.html



-------------------------------------------------------------------------------------------------------------------------------------------------------
Makinom Version Changelog
-------------------------------------------------------------------------------------------------------------------------------------------------------

Version 1.17.0:
- new: Unity 2019.3: Makinom is now compatible with Unity 2019.3 - use the Makinom for Unity 2019 version. Requires the 'Unity UI' package installed in your project.
- new: Editor: Update to the look of certain parts of the Makinom editor and component inspectors.
- new: Flying Texts: Positions: 'Ignore Scale' setting available when using 'Local Space'. Optionally ignore the scale when using positions in local space. By default disabled.
- new: Schematics: Change Position, Change Camera Position, Rotate To, NavMesh Destination, Rigidbody Position Force, Rigidbody Explosion Force: 'Ignore Scale' setting available when using 'Local Space'. Optionally ignore the scale when using positions in local space. By default disabled.
- new: Schematics: Animation Template, Play Legacy Animation, Play Mecanim Animation: 'Normalized Time' setting available when waiting for an animation to finish. Defines for which amount of the animation's time the schematic should wait, 0 being no wait time and 1 being full wait time. E.g. 0.5 would wait for half of the animation.
- new: Schematics: Animation Template, Play Legacy Animation, Play Mecanim Animation: 'Store Duration' settings available. Optionally store the duration of the played animation into a float variable.
- new: Schematics: Spawn Prefab: 'Set Scale' settings available when spawning at 'Center'. Optionally set the scale of the spawned prefab when spawning it at the center of all used game objects.
- new: Schematics: Game Option Dialogue: 'Change Value' setting available for 'Float' input type. Define the change value per input.
- new: Schematics: Change Fields: 'Increase Size' setting available when setting an array element. Optionally increase the size of an array (or list) field/property if the defined array index exceeds the array's size.
- new: Game Starter: 'Use Asset Bundle' setting available. Optionally load a project asset from an asset bundle.
- change: Editor: Schematics: The schematic editor now remembers the last path used to save a schematic as long as the editor is kept open. Saving another schematic will open the save file dialog at the last used path.
- fix: Asset Bundles: Fixed an issue where using 'Load From Memory' didn't work.


Version 1.16.0:
- new: Input Keys, Languages, Scene Object Types, Scene Objects: 'Short Name' setting available. Define a separate, shorter name - the name is used if no short name is defined. Short names can be added to UI and dialogues using text codes.
- new: Custom Text Codes: 'Text Codes' sub-section available in the 'Menus' section. Define custom text codes that can be used in other texts and dialogues. Scene objects can overrule these text codes if they're used on speaker actors in dialogues.
- new: Scene Objects, Scene Object Types: Custom Text Codes: 'Custom Text Codes' settings available. Scene objects, scene object types and scene object components can define custom text codes which will overrule the default custom text codes defined in 'Menus > Text Codes'. Dialogues using a speaker will use the actor's text codes.
- new: Game Controls, GUI Boxes: Menu Controls: 'Accept Left Click', 'Accept Middle Click' and 'Accept Right Click' settings available. Define which mouse buttons can be used to accept a choice when clicking on it. GUI boxes can override the default controls defined in the game controls.
- new: Game Controls: Interactions: 'In Children' and 'From Root' settings available in the 'Click Interaction' settings. Defines if interactions are searched in child objects (by default enabled) and from the root game object (by default disabled) of the clicked game object.
- new: GUI Layouts: Move Settings: 'Move Settings' available. Optionally move GUI boxes to their new positions instead of setting them directly.
- new: HUDs: 'Update By Selected Object' setting availabe in all HUD types. Optionally update the HUD's content when the selected object changed.
- new: Schematics: 'Close All Dialogues' setting available. Optionally closes all GUI boxes opened by the schematic when the schematic ends. By default disabled.
- new: Schematics, Formulas: Store Field: The 'Store Field' node now has a 'Failed' next slot in case a variable wasn't set (e.g. due to not finding the field/property). Old settings will be updated to link both 'Success' and 'Failed' slots to the old setting's 'Next' slot to prevent schematics/formulas from ending early.
- new: Schematics, Formulas: Store Function Result: The 'Store Function Result' node now has a 'Failed' next slot in case a variable wasn't set (e.g. due to not the function call failing). Old settings will be updated to link both 'Success' and 'Failed' slots to the old setting's 'Next' slot to prevent schematics/formulas from ending early.
- new: Schematics: Change Fields, Check Fields: 'Use Array' settings available for fields/properties. Optionally uses the field/property as an array, using the value of a defined index.
- new: Schematics: Rigidbody2D Body Type: 'Rigidbody2D Body Type' node available in 'Game Object > Rigidbody' nodes. Changes the physical behaviour type (body type) of a 'Rigidbody2D'.
- new: Editor: Add Buttons: Buttons to add new settings (e.g. adding new HUD elements) will now also be displayed after the last settings, i.e. you on longer have to scroll back up in case there's a lot of settings.
- fix: Interaction Controller: Disabling an interaction while it is within the trigger of an 'Interaction Controller' component could cause the interaction to be interactable after moving away and reenabling the interaction.
- fix: Interactions: Fixed a potential issue with click interactions.
- fix: Schematics: Change Position: Fixed an issue where moving by speed only on the Y-axis didn't move at all.
- fix: HUDs: New UI: Scroll bars where not interactable in some HUDs when using the new UI.
- fix: Formulas: Vector3 Magnitude: Adding a 'Vector3 Magnitude' node caused an error in the editor.
- fix: Schematics: UI Text: Fixed an issue that caused an error when loading a schematic with an 'UI Text' node that doesn't set the font of the component.


Version 1.15.0:
- new: GUI Layouts: 'GUI Layouts' sub-section available in 'Menus' section. GUI layouts can be used to place GUI boxes (e.g. in HUDs) on a defined layout, ignoring the position and anchor of the GUI boxes. GUI layouts can als be used to align content from different sources (e.g. different HUDs).
- new: Input Keys: Input Key: 'Negate Input' setting available for added input keys. Optionally negate the checked input when considering if an input happened for the combined input of all keys. E.g. use this to allow input if 'Shift' isn't held instead of held down.
- new: Game Settings: Asset Settings: 'Default Load Type' setting available. Define how asset bundles will be loaded, either using 'Load From File' (default) or 'Load From Memory'. Assets overriding the asset bundle path will also define a different load type.
- new: Menu Settings: 'Focus Left Click', 'Focus Middle Click' and 'Focus Right Click' settings available. Defines if left/middle/right mouse button clicks can be used to change focus to a GUI box. Using the left mouse button is by default enabled.
- new: HUDs: 'GUI Layout' settings available. Optionally use a GUI layout to place the HUD's GUI box.
- new: HUDs: 'Click To Foreground' setting available. Optionally bring a HUD's GUI box to the foreground of its GUI layer when clicking on it. If the currently focused GUI box is on the same layer it'll still be in front of the HUD.
- new: Schematics: Actors: 'Selected Data' actor type available. Optionally use game objects stored in selected data as an actor. The game object is selected whenever the actor is used in a node, i.e. changing the selected data will also change the actor for the following nodes.
- new: Schematics: Change Scene Object: 'Change Scene Object' node available in 'Game Object > Component' nodes. Changes the scene object used by a 'Scene Object' component.
- change: Node Editor: Pasting nodes from clipboard will now place them on the currently viewed layer instead of the layer they where copied from.
- change: Legacy GUI: Performance improvements when using the 'Legacy GUI' GUI system. Depending on the use case, this can improve performance up to 50%.
- fix: Schematics: Change Input ID: Fixed an issue where selecting a 'Change Input ID' node caused errors.
- fix: Pooling: Fixed an issue where game object pools where initialized twice when starting the game ('Game Starter' component).
- fix: HUDs: Control: Fixed an issue where input keys used in fixed udpate didn't recognize HUD inputs.
- fix: HUDs: Tooltip: Fixed an issue where the tooltip's GUI box flashes if it's displayed between the cursor and the content causing the tooltip.
- fix: Editor: Fixed an issue where maximizing and minimizing a docked editor caused an error.
- fix: Update UI Text, Update UI Slider: Fixed an issue that caused errors in the inspector of these components.
- fix: GUI Boxes: Choices: Fixed an issue where using icon size didn't adjust the size of choice button icons.


Version 1.14.1:
- new: Unity 2019: Makinom now supports Unity 2019. This removes all networking functionality, as this feature was removed by Unity. Makinom versions for Unity 2018 and below still retain networking functionality.
- new: Schematics: WebRequest Call: 'WebRequest Call' node available in 'Networking > Networking' nodes. Uses a web request to call a defined URL. Not available in Unity 5.6 and Unity 2017.
- new: Schematics: Store WebRequest Text: 'Store WebRequest Text' node available in 'Networking > Networking' nodes. Stores the result of a web request call to a defined URL into a string variable. Not available in Unity 5.6 and Unity 2017.
- new: Schematics: Store WebRequest Texture: 'Store WebRequest Texture' node available in 'Networking > Networking' nodes. Stores a texture downloaded by a web request call to a defined URL into a texture of the schematic. Not available in Unity 5.6 and Unity 2017.
- change: Unity 2019: Networking Settings: No settings are available in Unity 2019 due to the removed UNet functionality.
- change: Unity 2019: Schematics: Removed all deprecated networking nodes, e.g. WWW nodes, server/client nodes, etc.


Version 1.14.0:
- new: Editor: Assets: You can now use assets from other sources, e.g. asset bundles or placed in a 'Resources' folder. Previous settings will be updated automatically and use the 'Reference' asset source, i.e. the Makinom project stores the direct reference to the asset (as it has been before).
- new: Game Settings: Asset Settings: 'Asset Settings' available. Define base asset settings that are used in the project, e.g. the default path for asset bundles. Also allows changing asset sources throughout the entire project, e.g. changing all 'Reference' sources to 'Asset Bundle' (if the used asset is part of an asset bundle).
- new: Flying Texts: Changing the rotation and scale of the flying text's game object (e.g. using a 'Change Rotation' or 'Change Scale' node in the move event) will now affect the text's rotation and scale. Rotation is only supported on the Z-axis when using the legacy GUI (new UI supports rotation on all axes).
- new: Camera Positions: 'Ignore Scale' setting available when using 'Local Space'. Optionally ignore the target's scale when placing the camera in local space.
- new: Save Games: 'Data Path' save file type available. Stores save files in 'Application.dataPath'.
- new: Save Games: 'Save Folder' setting available for 'Persistent Data Path' and 'Data Path' save file types. Stores the save games in the defined folder in the data path.
- new: Input Keys: Unity Input Manager: 'Up/Down Full Axis' setting available when using 'Is Joypad Axis'. Optionally interpret 'Up' and 'Down' input handling as full axis value of 1/-1. E.g. use this when using a 'Down' input handling coming from a joypad axis as menu input, as otherwise the axis value recognized during 'Down' input would be too low.
- new: Animations: Mecanim Parameters: 'Use Hash ID' setting available. Using the hash ID of a Mecanim parameter's name to access the parameter is now optional. Accessing parameters via hash IDs is faster - disable this setting in case you get a warning like 'Parameter Hash 123456789 does not exist.'. By default enabled.
- new: GUI Boxes: Text Typing: 'Hide Ok/Cancel' setting available. Optionally hide the ok and cancel buttons while the text is typing.
- new: HUDs: Interaction: 'Interaction Source' setting available. Select where the displayed interaction is coming from, either the 'Interaction Control' of the player or from a game object below the cursor (or both).
- new: Schematics: Store Variables: 'Store Variables' node available in 'Value > Variables' nodes. Stores the variables from a defind source (e.g. global variables) into a file or PlayerPrefs variable (string). The data is stored as an XML-formatted string.
- new: Schematics: Load Variables: 'Load Variables' node available in 'Value > Variables' nodes. Loads the data stored in a file or PlayerPrefs variable (string) into a defined variable source. The data is loaded from an XML-formatted string.
- new: Schematics: Show Flying Text: 'Selected Data Settings' available. Optionally use the flying text's game object and store it in selected data.
- change: Scripting: Save Games: Changed code structure to allow adding custom save file handling without changing Makinom's code. Descend your custom code from the 'BaseSaveFileHandling' class, use the built-in classes as examples.
- change: Save Games: The 'File' save game method has been renamed to 'Persistent Data Path'.
- fix: Schematics: Fixed an issue where moving/rotating a game object over time in multiple running machines at the same time could lead to some machines not progressing any further.
- fix: Schematics: Shake Object: Changing the time scale to 0 while shaking a game object will now stop the shaking (until the time scale is restored to a value above 0).


Version 1.13.0:
- new: Game Controls: 'Cursor Hold Timeout' setting available. Defines the time in seconds that has to pass between consecutive cursor moves when the input is received without a break (e.g. holding a key).
- new: Input Keys: Unity Input Manager: 'Use Raw Axis' setting available. Optionally use the raw axis value, without smoothing filtering applied (Input.GetAxisRaw). This can be useful for vertical/horizontal inputs used for dialogues.
- new: Game Settings: 'Visibility Settings' available. Define how visibility is checked, either checking the renderer's visibility to any camera, the position within viewport space of the main camera or by checking the frustum planes of the main camera. Defaults to checking the renderer's visibility.
- new: Save Game Menu: 'Delete File' settings available. Optionally use an input key to delete the currently selected save file (choice) in 'Save Game Menu' and 'Load Game Menu' dialogues.
- new: Save Game Menu: 'Use Delete Key' setting available in 'Save Game Menu' and 'Load Game Menu' dialogues. Optionally use the delete input key defind in the 'Delete File' settings.
- new: GUI Boxes: Choice Settings: 'Use Fixed Offset' settings available for 'Circle' type choice mode. Optionally define a fixed offset in degrees between choices. If disabled, the offset is calculated based on the number of choices and the 'Circle Degree' setting.
- new: Schematics: Is Visible: 'Custom Check' settings available. Optionally use a custom visibility check to check a game object's visibility.
- new: Schematics: Curve Move: 'Move Time' settings available. Optionally define a time in seconds used to perform the curve move. The curves will be scaled by the time, using the highest curve time as base.
- new: Schematics: Curve Move: 'Multiply By' settings available for the X, Y and Z axis settings. Multiplies the curve's value by the defined value (e.g. the distance between 2 game objects).
- change: Schematics: Dialogue Nodes: Stopping a schematic will now close a currently displayed dialogue.
- change: Editor: About: The version now also displays which Unity version it is intended for (i.e. Unity 5.6, Unity 2017 or Unity 2018).


Version 1.12.0:
- new: Float Fields: 'Vector3 Variable Magnitude' selection available in all float field type selections. Uses the magnitude (length) or square magnitude (squared length) of a Vector3 variable.
- new: Editor: Color Fields: Added support for HDR color picker.
- new: GUI Boxes: Input Field Settings: 'Number Input Type" settings available. Define how number value inputs are displayed, either as a 'Slider' or as 'Horizontal Buttons'.
- new: HUDs: Toggle Key: 'Audio Clip' settings available. Optionally play an audio clip when using the toggle key.
- new: Schematics: Value Input Dialogue: 'Accept' and 'Cancel' option types available. Add button inputs to accept or cancel the changes. Using button inputs will hide the ok/cancel buttons of the GUI box.
- new: Schematics: Value Input Dialogue: 'Number Input' settings available. Number value inputs can optionally override the setting of the used GUI box and use a different number input type.
- new: Schematics: Vector3 Direction: 'Vector3 Direction' node available in 'Value > Vector' nodes. Stores the direction from one Vector3 (position) to another into a Vector3 variable.
- new: Schematics: Rigidbody Add Force, Rigidbody Add Torque, Rigidbody Position Force: 'Force Multiply' setting available. Multiplies the defined force vector by the defined float value. By default set to 1.
- change: GUI Boxes: Having 'Select First' enabled and clicking on a not selected choice button will now play the 'Cursor Move' audio clip.
- fix: Screen Fader: Fixed an issue where the screen fader didn't occupy the full screen when using the new UI and high differences between default screen size and actual screen size (e.g. 1080x1920 and 1920x1080).
- fix: GUI Boxes: New UI: Fixed an issue where clicking on inactive choices didn't select the choice when using the new UI.
- fix: HUDs: Toggle Key: Fixed an issue where 'Use While Key' actually reversed the state.


Version 1.11.2:
- fix: Unity 2018: Removed legacy network functionality for Unity 2018.


Version 1.11.1:
- new: Music Player: 'From Current Time' setting available. Optionally play music from the currently playing music's time. This is used per music channel, i.e. you can only play music from the time of the same channel's current music.
- new: Schematics: Show Dialogue: 'Not Controlable' setting available for 'Message' type dialogues when not using 'Wait'. Optionally prevent the player from closing a dialogue when not using the 'Wait' option to continue the schematic while showing the dialogue. The dialogue has to be closed using a 'Close All Dialogues' node before the schematic ends.
- new: Schematics: Game Option Dialogue: 'Is PlayerPrefs' setting available for 'Custom' options. Optionally store the values in PlayerPrefs instead of variables.
- change: Scripting: Interaction Controller: The 'InteractionController' class has been adjusted to have all functions available for overrides.
- fix: Editor: Fixed an issue where having the Makinom editor open while playing resulted in an error.
- fix: Game Options: Fixed an issue where changing volumes as integers could result in decreasing volumes when opening the options menu.
- fix: Schematics: Store Collider Bounds: Fixed an issue where wrong values where stored when using 'Random Position' within a collider.
- fix: Schematics: Rotate To: Fixed an issue when fading the rotation.
- fix: Dialogues, Audio: Fixed an issue where dialogue audio clips could change the audio source settings (like pitch) of the main Makinom audio player (e.g. for ok/cancel clips).
- fix: GUI Boxes: Choices: Fixed an issue where choice buttons where not shown in their proper normal state when opening a GUI box using the new UI.


Version 1.11.0:
- new: Unity 2018.1: Makinom now supports Unity 2018.1.
- new: Game Controls: Control Machines: 'Use Template' settings available. Optionally use a machine template as a control machine.
- new: Schematic Nodes: Pause Audio Listeners: 'Pause Audio Listeners' node available in 'Animation + Audio' nodes. Pauses or unpauses all 'AudioListener' components in the scene.
- change: Schematic Nodes: External Call: The 'External Call' node is no longer available when using Unity 2018.1.
- change: Schematic Nodes: External Eval: The 'External Eval' node is no longer available when using Unity 2018.1.


Version 1.10.2:
- new: Reflection: You can now access nested fields, properties and functions. E.g. 'nested.value' would access the field/property 'value' of the field/property 'nested' of the defined class. Reflection is e.g. used by the 'Function' schematic nodes.
- new: Game Settings: Unity Wrapper: 'Random Number Generation' settings available. Optionally replace standard Unity random number generation (Random.Range) with custom functions.
- new: GUI Boxes: Choice Settings: 'No Click Accept' setting available. Optionally disable accepting choices by clicking on them, i.e. only allow accepting via the 'Accept' input key.
- new: GUI Boxes: Choice Settings: 'Highlight Unfocused' setting available. Showing the selected choice skin is now optional for unfocused GUI boxes (only for legacy GUI).
- new: Schematics: Selected Data Count: 'Selected Data Count' node available in 'Value > Selected Data' nodes. Checks the count of data stored in a selected data list.
- new: Schematics: Change Music: 'Target Volume' setting available. Define the volume a music clip should be played at. This doesn't change the overall music volume or the channel's volume, only at which volume the music clip itself is played at.
- new: Schematics: Pause Notifications: 'Pause Notifications' node available in 'UI > Dialogue' nodes. Pauses or resumes displaying notifications (e.g. 'Notification' type dialogues). Paused notifications will not be displayed and their visible time doesn't progress.
- new: Music Player: 'Target Volume' setting available. Define the volume a music clip should be played at. This doesn't change the overall music volume or the channel's volume, only at which volume the music clip itself is played at.
- change: Performance: Some small performance improvements for several tasks and data loading.
- change: Editor: Replaced most float fields that only allowed input between a defined minimum and maximum value with slider fields.
- change: Editor: The editor will now check data consistancy of data array when loading a project, e.g. adding missing languages. This is only done in the editor, not when playing the game. Save the project in the ORK editor to save the updated settings.
- change: Editor: Game Object Pools: The 'General Scene Check' settings can now be found in the 'General Settings' of the 'Base/Control > Game Object Pools' section.
- change: Editor: GUI Boxes, Menu Settings: The default GUI box settings can now be found in the 'General Settings' of the 'Menus > GUI Boxes' section.
- change: Editor: Changes to the editor's background systems for future updates and some performance improvements.
- change: Scene Changers: The player is only spawned when the target scene is in the list of loaded scenes.
- change: Formulas: Random Value: Changed how the 'As Int' setting generates a random integer number. 'Value 2' setting is now used exclusive.
- change: New UI: If an 'Event System' component is already present, ORK will no longer create its own.
- change: Schematics: Show Dialogue: The 'Queued Notification' type has been changed to the general 'Notification' type. You can queue the notification using the new 'Queue Notification' setting. Old settings are updated automatically.
- fix: Editor: Fixed an issue where name fields lost focus when typing in them. This is a workaround for a bug on Unity's side since Unity 2017.2.


Version 1.10.1:
- new: Game Settings: Unity Wrapper: 'Unity Wrapper' settings available. Optionally replace standard Unity functionality with custom function calls. Currently supports instantiating game objects, destroying game objects and loading scenes.
- new: Scripting: Extend Unity wrapper selections with custom classes. Descend your class from the 'BaseInstantiateSetting' class for game object instantiation, the 'BaseDestroySetting' class for game object destruction and the 'BaseLoadSceneSetting' class for scene loading (namespace 'Makinom.Wrapper').
- new: String Fields: 'Data Path' and 'Persistent Data Path' selections available in all string field type selections. Uses a defined path based on Application.dataPath (game folder) or Application.persistentDataPath (persistent data folder).
- new: Global Volume: The global volume is used to scale both the music and sound volumes.
- new: Game Settings: 'Global Volume' start volume setting available. Defines the global volume when initializing Makinom.
- new: Save Game Menu: 'Global Volume' store game option setting available. Optionally stores the global volume outside of save games in the PlayerPrefs.
- new: HUDs: Value Bars: 'Images Per Icon' setting available when displaying a value bar as icons. Optionally use the defined images per icon, i.e. the 'Percent' setting is used based on the icon value of each individual icon.
- new: HUDs: Control: 'Show From Input' setting available in 'Control' HUD elements. Optionally show the pressed button state and axis/joystick positions from the used input keys when not getting any click/touch input on the virtual control. Can be used to highlight input coming from other sources.
- new: Schematics: Read Text File: 'Read Text File' node available in 'Value > Text File' nodes. Reads the text from a text asset and stores it into a string variable.
- new: Schematics: Read Text File Lines: 'Read Text File Lines' node available in 'Value > Text File' nodes. Reads the text from a text asset line by line and adds each line to a string variable list.
- new: Schematics: Write Text File: 'Write Text File' node available in 'Value > Text File' nodes. Writes into a text file.
- new: Schematics: Write Text File Lines: 'Write Text File Lines' node available in 'Value > Text File' nodes. Writes a string variable list's values into a text file (each value being a line).
- new: Schematics: Game Option Dialogue: 'Global Volume' game option type available. Changes the global volume.
- new: Schematics: Game Option Dialogue: 'Mute Global Volume', 'Mute Music Volume' and 'Mute Sound Volume' game option types available. Mutes/unmutes the global, music and sound volume.
- new: Schematics: Change Global Volume: 'Change Global Volume' node available in 'Audio + Animation > Audio' nodes. Sets, fades, mutes or unmutes the global volume.
- new: Schematics: Change Music Volume, Change Sound Volume: 'Mute' and 'Unmute' changes available. Optionally mute or unmute the music or sound volume. Muting a volume will not change the actual volume, but still result in 0 volume.
- change: Schematics: Show Flying Text: You can now define multiple positions (with random offsets) to use randomly or iterate through.
- change: Scripting: The 'MusicHandler' class has been replaced by the 'AudioHandler' class. The audio handler is responsible for volumes, the main audio source and music channels.
- change: New UI: Buttons: Accepting/canceling a choice or dialogue will now fire the 'OnClick' event of the used prefab's 'Button' component on the selected choice or the ok/cancel buttons. This only happens when accepting/canceling via input keys, not via click/touch (as that already fires 'OnClick').
- fix: GUI Boxes: Ok/Cancel Buttons: Fixed an issue where using a custom skin for the ok/cancel buttons wasn't used when using the legacy GUI.
- fix: GUI Boxes: Fixed an issue that could lead to the name box having the wrong size when using the new UI and the same prefab for content box and name box.
- fix: Collision Camera: Fixed an issue where the collision camera resets to a wrong position after a camera change.


Version 1.10.0:
- new: Editor Settings: 'Allow View Limiting' setting available. You can optionally allow showing only one base foldout at a time. Adds navigation buttons above and below the settings and a popup field to the foldout quick jump list. A double click on a foldout in the jump list will also limit the view to the parent base foldout. By default enabled.
- new: String Fields: 'Date and Time' selection available in all string field type selections. Uses the current date and time as a formatted string (e.g. '2017-12-31 17:05:01').
- new: Float Fields: Time of Day: 'Is UTC' setting available for 'Time of Day' float type selections. Optionally use the time of day in UTC format instead of local time.
- new: Plugins: Plugins can now also be provided as scripts instead of DLLs.
- new: GUI Boxes: Open/Close Box Behaviour: 'Audio Clip' settings available. Optionally play an audio clip when opening or closing a GUI box.
- new: Schematics: Change Date and Time: 'Change Date and Time' node available in 'Value > Date and Time' nodes. Changes a date/time string using a float value, e.g. adding 5 hours to a date/time.
- new: Schematics: Check Date and Time: 'Check Date and Time' node available in 'Value > Date and Time' nodes. Checks a date/time string against a defined date/time string. E.g. check if a date/time is before a defined date/time or between two defined dates/times.
- new: Schematics: Date and Time to Float: 'Date and Time to Float' node available in 'Value > Date and Time' nodes. Stores a date/time string as a float variable. Either stores the whole date/time value in seconds (since 1-1-1970), or stores parts of it, e.g. the second, hour or year.
- new: Schematics: Date And Time Difference: 'Date and Time Difference' node available in 'Value > Date and Time' nodes. Stores the difference between 2 date/time values (string) in as a float variable, e.g. the whole difference in seconds or only the seconds difference.
- new: Schematics: WWW Call: 'WWW Call' node available in 'Networking > Networking' nodes. Does a WWW call with a defined URL and optionally waits for the call to finish. Can optionally store the progress in a float variable (e.g. for a progress bar HUD).
- new: Schematics: Store WWW Text: 'Store WWW Text' node available in 'Networking > Networking' nodes. Stores the result of a WWW call into a string variable.
- new: Schematics: Store WWW Texture: 'Store WWW Texture' node available in 'Networking > Networking' nodes. Stores a texture downloaded by a WWW call into a defined texture of the schematic. Can optionally store the progress in a float variable (e.g. for a progress bar HUD).
- new: Interaction Machines: Move To Interaction: 'Override Speed' settings available. Optionally override the speed used to move to the interaction for each individual interaction. Can optionally store the progress in a float variable (e.g. for a progress bar HUD).
- change: Save Games: Variable keys with spaces (e.g. 'variable key') are now supported by save games.
- change: Scripting: The 'MachineHandler' class is now part of the gameplay source code. It handles updating running schematics.
- change: Scripting: The 'MachineStackHandler' class has been removed. The machine stacks are now handled by the 'MachineHandler' class.
- change: Scripting: The 'PlaySchematic' functions implementation have been moved from the locked 'CoreSchematic' class to the 'Schematic' class (i.e. available in the gameplay source code).
- change: Editor: Inspectors: Changed some of the Makinom component inspectors to have some rarely used sub-settings as foldouts and automatically fold them.
- fix: GUI Boxes: Choice Icon: Fixed an issue where the choice selection icon was placed at the wrong position when tabs where displayed at the top.
- fix: GUI Boxes: New UI: Fixed an issue that could lead to flickers when showing 2 dialogues in sequence without a pause when using the new UI.
- fix: Schematics: Rotation Nodes: Fixed issues when rotating a game object on the X-axis at 90 and -270 degrees.
- fix: HUDs: Interaction: Fixed an issue when opening an 'Interaction' type HUD in the GUI editor.


Version 1.9.2:
- new: Editor Settings: 'Language Selection' settings available. Handles how settings for different languages are displayed and selected in the editor. Either 'List' all settings, select the language with a 'Popup' or 'Buttons' and only show the selected language's settings.
- new: String Fields: 'GUID' selection available in all string field type selections. Creates a new, unique GUID string.
- new: Game Settings: Audio Settings: 'Initial Music Channel' settings available. Optionally add music channels at the start of the game with a defined start volume and audio mixer group output.
- new: Save Game Menu: Store Game Options: 'Store Game Options' settings available. Optionally store the language, sound volume and music volume outside of save games. Changes to these settings will be stored in PlayerPrefs and loaded when starting the application. The settings are still also saved/loaded with save games.
- new: Save Game Menu: 'All Auto Save Slots' setting available in 'Load Game Menu' settings. Optionally show all auto save slots, displaying unused slots as inactive buttons.
- new: Save Game Menu: 'Custom Skin' settings available in 'Save Game Menu' and 'Load Game Menu' settings. Optionally use custom choice skins for file and empty file buttons.
- new: Menu Settings, GUI Boxes: GUI Skins: 'Limit To Scrollbar' setting available when using the new UI. Optionally disable scrolling by dragging and mouse wheel.
- new: GUI Boxes: 'Reset Unity Input' setting available. Resetting Unity inputs when accepting/canceling a GUI box is now optional per GUI box. Disable this setting when you want to use a 'Hold' input key to skip through dialogues. By default enabled.
- new: GUI Boxes: 'Own Key Scroll Speed' settings available. Optionally override the default key scroll speed defined in the menu settings for a GUI box.
- new: GUI Boxes, Game Controls: 'Use Scroll Axis' settings available. Optionally define an input key that is used to scroll the content of a GUI box.
- new: GUI Boxes: Choice Settings: 'Offset To Text' setting available. Defines the offset between the text and choices. Only used if there is content before the choices.
- new: HUDs: Value Bars: 'From Zero' setting available when using icons to display value bars. Optionally start the icon display from 0 instead of the minimum value. E.g. a current value of 4 would display 4 icons from zero, but 3 from a minimum value of 1.
- new: Schematic Nodes: Auto Save: 'Show Message' setting available. Showing the auto save message is now optional.
- new: Schematic Nodes: Reset Input Axes: 'Reset Unity Input' setting available. Resetting Unity inputs is now optional when resetting inputs. If disabled, only resets Makinom's internal input keys. By default enabled.
- new: Schematic Nodes: Set Audio Source Output: 'Set Audio Source Output' node available in 'Animation + Audio/Audio Mixer' nodes. Sets the output of audio sources to a defined auto group mixer.
- new: Schematic Nodes: Set Music Channel Output: 'Set Music Channel Output' node available in 'Animation + Audio/Audio Mixer' nodes. Sets the output of a music channel to a defined auto group mixer.
- new: Schematic Nodes: Shake Object: 'Shake Object' node available in 'Movement > Movement' nodes. Shakes a game object.
- change: Schematic Nodes: Show Flying Text: 'Show Notification' node has been renamed to 'Show Flying Text. The game object created for flying texts is now named '_FlyingText' instead of '_DisplayText'.
- fix: GUI Boxes: New UI: Fixed issues where choice buttons could flash when fading in/out a GUI box.
- fix: GUI Boxes: Name Box: Fixed an issue where the name box wasn't placed correctly when not using 'Relative Bounds' and the new UI.
- fix: HUDs: Fixed an issue where anchoring HUD elements from right to left could change the layout when using the 'Outside Bounds' setting or the new UI.


Version 1.9.1:
- new: Unity 2017.1: Makinom now supports and requires Unity 2017.1.
- new: Schematic Nodes: Change Director State: 'Change Director State' node available in 'Animation + Audio > Playable' nodes. Changes the state of a 'Playable Director' component to either play, pause, resume or stop playback.
- new: Schematic Nodes: Change Director Asset: 'Change Director Asset' node available in 'Animation + Audio > Playable' nodes. Changes the playable asset of a 'Playable Director' component.
- new: Schematic Nodes: Is Director Playing: 'Is Director Playing' node available in 'Animation + Audio > Playable' nodes. Checks if a 'Playable Director' component is currently playing.
- new: Schematic Nodes: Change Director Time: 'Change Director Time' node available in 'Animation + Audio > Playable' nodes. Changes the time or initial time of a 'Playable Director' component.
- new: Schematic Nodes: Store Director Time: 'Store Director Time' node available in 'Animation + Audio > Playable' nodes. Stores the time, duration or initial time of a 'Playable Director' component into a float variable.
- new: Schematic Nodes: Change Director Update Mode: 'Change Director Update Mode' node available in 'Animation + Audio > Playable' nodes. Changes the time update mode of a 'Playable Director' component.
- new: Schematic Nodes: Change Director Wrap Mode: 'Change Director Wrap Mode' node available in 'Animation + Audio > Playable' nodes. Changes the wrap mode of a 'Playable Director' component.
- change: Portrait Positions: 'Vertical Scale' setting has been replaced by 'Portrait Scale' selection. Now supports 'None' scale, 'Horizontal' scale (scaling based on screen width) and 'Vertical' scale (scaling based on screen height).


Version 1.9.0:
- new: Menu Settings: 'Default Icon Size' settings available. Define the default icon size for all UI. By default using the original size of icons.
- new: GUI Boxes: 'Icon Size' settings available. Optionally override the default icon size defined in the menu settings for each GUI box individually.
- new: GUI Boxes: 'Cursor Over' setting available. Determines if a GUI box is recognized by cursor over checks. This is e.g. used by UI blocks in input keys. By default enabled.
- new: GUI Boxes: Menu Controls: 'Menu Controls' settings available. GUI boxes can optionally override the default menu controls (accept, cancel, horizontal and vertical input).
- new: Text Codes: New text codes available to define icon sizes. Use the '<iconsize>' text code to define the size for all following icons ('<iconsize>' resets to the original size, '<iconsize w=X>' sets to width X and scales the height, '<iconsize h=X>' sets to height X and scales the width, '<iconsize w=X h=Y> sets to width X and height Y).
- new: Text Codes: New text codes available to append to icon text codes to change the icon size of a single icon. ' w=X' sets to width X and scales the height (e.g. '<inputkey.icon=2 w=100>'), ' h=X' sets to height X and scales the width (e.g. '<inputkey.icon=2 h=50>'), ' w=X h=Y sets to width X and height Y (e.g. '<inputkey.icon=2 w=100 h=50>').
- new: Custom Choice Skins: Define a custom GUISkin (or prefab when using the new UI) for choices/buttons and content layouts throughout the framework. This can be used to highlight choices with a special button, also allows changing the icon size. Available wherever buttons are used, e.g. 'Choice' type dialogues.
- new: Input Keys: 'UI Blocks Input' setting available. Optionally block input for an input key while the cursor is over a GUI box.
- new: Game Controls: Player Components: 'SC Destroy Player' setting available. Optionally destroy the player's game object before changing scenes. Enabling this option can help with some custom player controls setting the player to don't destroy on load.
- new: HUDs: Click Action: 'Tagged Machine' click action type available. Optionally start 'Tagged Machine' components on the user or all tagged machines in the scene when clicking on a HUD element.
- new: Editor Settings: 'Text Area Color' setting available. Defines the text color of text areas.
- new: Schematic Nodes: Show Dialogue: 'Custom Skin' settings available for choices. Optionally use a different GUI skin (or prefab when using the new UI) for individual choice buttons.
- new: Schematic Nodes: Show Dialogue: 'Repeat Condition Checks' setting available for 'Choice' type dialogues. Optionally repeat checking the conditions for displaying choices while displaying the dialogue. The dialogue will be updated if the conditions change.
- new: Schematic Nodes: Call HUD: 'Change Users' setting available. Changing HUD user objects when calling a HUD is now optional.
- change: New UI: Changed how inactive box/button colors work when used together. Instead of forcing inactive box color on inactive buttons, they'll now blend together.
- change: Menu Settings: The 'Default Screen Size' is now set to 1920*1080 in new projects.
- change: UI: Icons in text now cause less distance between lines.
- change: Scripting: Custom schematic nodes no longer need to be placed in the 'Makinom.Schematic.Nodes' namespace.
- change: Scripting: Custom formula nodes no longer need to be placed in the 'Makinom.Formula.Nodes' namespace.
- change: Scripting: Input Keys: Changed code structure to allow adding custom input key types without changing Makinom's code. Descend your custom input key code from the 'BaseInputIDKeySetting' class, use the built-in input key classes as examples.
- change: Scripting: HUDs: Changed code structure to allow adding custom HUD types without changing Makinom's code. Descend your custom input key code from the 'BaseHUDSetting' class, use the built-in HUD classes as examples.
- change: Scripting: Bool Values: Changed code structure to allow adding custom bool value types without changing Makinom's code. Descend your custom bool value type's code from the 'BoolValue_BaseType', 'FormulaBool_BaseType' (for formulas) and 'SchematicBool_BaseType' (for schematics) classs, use the built-in classes as examples.
- change: Scripting: Float Values: Changed code structure to allow adding custom float value types without changing Makinom's code. Descend your custom float value type's code from the 'FloatValue_BaseType', 'FormulaFloat_BaseType' (for formulas) and 'SchematicFloat_BaseType' (for schematics) classs, use the built-in classes as examples.
- change: Scripting: String Values: Changed code structure to allow adding custom string value types without changing Makinom's code. Descend your custom string value type's code from the 'StringValue_BaseType', 'FormulaString_BaseType' (for formulas) and 'SchematicString_BaseType' (for schematics) classs, use the built-in classes as examples.
- change: Scripting: Vector3 Values: Changed code structure to allow adding custom Vector3 value types without changing Makinom's code. Descend your custom Vector3 value type's code from the 'Vector3Value_BaseType', 'FormulaVector3_BaseType' (for formulas) and 'SchematicVector3_BaseType' (for schematics) classs, use the built-in classes as examples.
- fix: New UI: Fixed some issues where choice buttons where flashing when updating the content of GUI boxes.
- fix: Schematic Nodes: Change Material: Fixed an issue where changing indexed materials didn't work.
- fix: GUI Boxes: New UI: Fixed an issue where the ok/cancel buttons wheren't removed from a content box when not using a button prefab.
- fix: New UI: Text Notifications: Fixed an issue where text notifications didn't scale when using the new UI.
- fix: HUDs: GUI Editor: Fixed an issue where typing text codes in the HUD GUI editor could result in errors.


Version 1.8.0:
- new: Unity 5.6: Makinom now supports and requires Unity 5.6.
- new: Editor: Multi-window editor available. Optionally open multiple instances of the Makinom editor using the 'Makinom (Multi-Window)' menu item or 'CTRL+ALT+SHIFT+M' keyboard shortcut in Unity. All open Makinom editors will be editing the same project.
- new: Input Keys: 'Content' settings available. Define name, description and icon of input keys (per language). Previous settings (only internally used name) will be updated automatically. There are new text codes available to add input key information to texts.
- new: GUI Layers: 'GUI Settings' available. Optionally override the default GUI scale and anchor for a GUI layer. Allows using GUI scaling per GUI layer.
- new: Text Codes: Date: '<date.local=X>' and '<date.utc=X>' text codes available to display the current real date and time in a defined format (replacing 'X'). The format is defined using C# date and time format options, e.g. '<date.local=yyyy-MM-dd H:mm:ss>' formats to '2017-01-22 17:05:01'.
- new: Save Game Menu: 'Custom' save functionality available. Saving to 'Custom' save type allows defining 4 static functions to handle your custom save game functionality.
- new: Game Object Selections: 'From Root' and 'Child Object' settings available in all game object selections.
- new: Schematic Nodes: Change Time Scale: 'Reset' setting available. Optionally reset the time scale to the previous value. Time scales will now keep track of the performed changes.
- change: Schematic Nodes: Change Light Node: 'Lightmap Bake Type' replaces the deprecated 'Lightmapping Mode' setting (Unity 5.6).
- change: Schematic Nodes: Audio Reverb Filter: 'Room Rolloff' settings removed due to being deprecated in Unity 5.6.
- fix: Save Games: Fixed an issue where the used text codes where saved as a save game's file info instead of the values they represent. This could lead to save game files displaying wrong information when viewed in a different game run.
- fix: Node Editor: Fixed an issue where selecting the 'Set Game Time' node caused the editor to display things in the wrong order.
- fix: Schematics: Fixed an issue where the 'Child Object' setting wasn't displayed in object selections.
- fix: Save Games: Fixed an issue where using compression and encryption of save games didn't work together.


Version 1.7.0:
- new: Editor Settings: 'Sort Enums' and 'Separate Enums' settings available. Enum popup fields will be sorted alphabetically and in some cases separated into sub-lists. By default enabled.
- new: Editor Settings, Node Editor: 'Show Enable Toggle' setting available. Optionally shows a toggle to enable/disable a node in the upper-right corner of the nodes. By default enabled.
- new: Editor Settings, Node Editor: 'Merge Single Slot' setting available. Optionally makes the 'Next' slot of single-slot nodes part of the info area. By default enabled.
- new: Input Keys: 'In Fixed Update' setting available. Stores input for use in fixed update ticks and allows using down/up input in machines running in 'Fixed Update'. By default enabled.
- new: Float Fields: 'Distance' selection available in all float field type selections. Uses the distance between 2 defined game objects.
- new: Scene Changers: 'Use Spawn Offset' setting available. Optionally use the offset of the player to the scene changer when spawning in the new scene.
- new: Schematic Nodes: Change Color: 'Change Color' node available in 'Animation + Audio > Fade' nodes (and others). Changes, fades, flashes or starts/stops blinking the color of renderers, lights or color fields/properties. This node replaces the 'Fade Object' and 'Blink Object' nodes, your settings will automatically update.
- new: Schematic Nodes: Change Light Float: 'Change Light Float' node available in 'Game Object > Light' nodes. Sets or fades float values of 'Light' components, e.g. intensity, spot angle or shadow strength.
- new: Schematic Nodes: Change Light Mode: 'Change Light Mode' node available in 'Game Object > Light' nodes. Changes the mode of 'Light' components, e.g. the light type, lightmapping mode or render mode.
- new: Schematic Nodes: Change Light Cookie: 'Change Light Cookie' node available in 'Game Object > Light' nodes. Changes the cookie texture of 'Light' components.
- new: Schematic Nodes: Light Culling Mask: 'Light Culling Mask' node available in 'Game Object > Light' nodes. Changes the culling mask of 'Light' components.
- new: Schematic Nodes: Show Dialogue: 'Show Inactive' setting available for choices. Optionally show choices that are inactive due to their defined conditions as inactive buttons instead of hiding them. Setting available per choice.
- new: Schematic Nodes: Follow Path: 'Path Point Timeout' setting available in 'Follow Path' nodes. The moving object can optionally wait for a defined amount of time at path points before continuing movement.
- new: Schematic Nodes: Reset Input Axes: 'Reset All' and 'Input Key' settings available in 'Reset Input Axes' nodes. Optionally reset only a defined input key instead of all input.
- new: Interaction Controller: 'Interact With Nearest' settings available. Optionally interact with the interaction nearest to the interaction controller's position (and a defined offset).
- change: Schematic Nodes: Fade Object, Blink Object: The 'Fade Object' and 'Blink Object' nodes have been replaced by the 'Change Color' node. Your old nodes will automatically update.
- change: Value Selections: Changes to the data structure of value selections (e.g. float values). This improves save and load times in the editor and load times in-game.
- fix: UI: Value Bars: Fixed an issue when using icon value bars with limited bar display.
- fix: GUI Boxes: Choices: Fixed an issue where the initially selected choice wasn't highlighted when using the new UI.
- fix: New UI: Fixed an issue where not using a prefab for the content box could result in mouse over selection not working correctly.


Version 1.6.0:
- new: Unity 5.5: Makinom now supports and requires Unity 5.5.
- new: Editor: Foldout Jump List: Optionally display a quick jump list for all available foldouts on the right side of the editor. Clicking on the foldout in the list will scroll to the settings.
- new: Menu Settings: 'Unfocused Mouse Over' setting available when using 'Mouse Over Selection'. Optionally also uses mouse over selection for unfocused GUI boxes.
- new: GUI Boxes: Choice Settings: 'Info Separation' settings available. Optionally separate content and info of the choice (which would otherwise overlap each other).
- new: Schematic Nodes: Check Object Hierarchy: 'Check Object Hierarchy' node available in 'Game Object > Game Object' nodes. Checks if a game object has a parent or child object (or both).
- new: Schematic Nodes: Show Dialogue: 'Store Selection' settings available in 'Choice' type dialogues. Optionally store/load the selected choice using an 'Int' variable.
- new: Schematic Nodes: Fade Object, Blink Object: 'Use Color Field' settings available. Optionally fade/blink a defined color field or property of a component instead of a renderer.
- change: Editor: Slightly changed the Makinom editor look.
- change: Spawn Points: A random spawn point with the used 'Spawn ID' will be used when multiple spawn points with the same 'Spawn ID' are in a scene. Until now, the first found spawn point with the same 'Spawn ID' has been used.
- fix: Rotations: Fixed an issue with rotations on the X-axis.
- fix: GUI Boxes: Choice Settings: Fixed an issue where the info aligment settings where ignored.
- fix: GUI Boxes: Fixed an issue where some content box anchor selections could initially place the GUI box at the wrong position when using the new UI.


Version 1.5.0:
- new: Unity 5.4: Makinom now requires Unity 5.4.
- new: String Fields: New automatic popup selection for string value fields. The popup will display matching variable keys and other data for selection while you type. Can be turned off in 'Editor > Editor Settings' in the 'Popup Field Settings'.
- new: Reflection Fields: New automatic popup selection for reflection string fields (e.g. for component/class name input). The popup will display matching reflection data (e.g. class names, function names) for selection while you type. Can be turned off in 'Editor > Editor Settings' in the 'Popup Field Settings'.
- new: Selected Data: Store various data in 'Selected Data' lists identified by a 'Data Key' to separate different lists. Data could be game objects, components or variable handlers (i.e. the handler holding all variables of an origin). Selected data is available like variables, i.e. local (formulas, schematics), global and bound to game objects using 'Object Variable' components. Selected data isn't saved in save games.
- new: Variables: Selected Data: 'Selected Data' variable origin available. Uses variable handlers stored in selected data as origin.
- new: Game Settings: Performance Settings: 'Pool Selected Data Handler Lists' and 'Pool Object Lists' settings available. Define the pools for keeping lists of selected data handlers and objects for performance improvements. These lists are used nearly whenever selected data is changed or checked.
- new: Node Editor: Swap Nodes: You can swap 2 selected nodes using the 'Swap Nodes' button or context menu item. The 2 nodes will exchange their next node slots and positions, as well as connections leading to them. Only works when 2 nodes are selected, doesn't work when the start node or a 'Layer Gate' node is selected.
- new: Formulas: Game Object Selections: 'Use Root' and 'Child Object' settings available in all game object selection fields in formulas. Optionally use the root game object and/or a child object of a selected game object.
- new: Formula Nodes: Clear Variables, Transfer Variables, Variable Exists: 'Scope' setting available when using 'Object' variable origin. Define the scope of object variable components that will be used. By default set to 'In Children'.
- new: Formula Nodes: Clear Selected Data: 'Clear Selected Data' node available in 'Selected Data' nodes. Clears/removes selected data. Either removes all data of a defined data key, or removes data from all keys (when using an empty data key).
- new: Formula Nodes: Select Variable Handlers: 'Select Variable Handlers' node available in 'Selected Data' nodes. Uses variable handlers to change selected data. A variable handler stores all variables of an origin, e.g. global variables or object variables of a game object.
- new: Formula Nodes: Select Components: 'Select Components' nodes available in 'Selected Data' nodes. Uses components to change selected data.
- new: Formula Nodes: Select Game Objects: 'Select Game Objects' nodes available in 'Selected Data' nodes. Uses game objects to change selected data.
- new: Schematics: 'Use End Slots' setting available in the 'Settings' node. Enables using the 'Stop' and 'End' slots in the schematic. If disabled, the slots wont be available/displayed.
- new: Schematics: Stop Slot: 'Stop' slot available in the 'Settings' node. Optionally execute nodes connected to the 'Stop' slot when the machine has been stopped (after the schematic finished executing). The 'End' slot nodes wont be executed in this case.
- new: Schematics: End Slot: 'End' slot available in the 'Settings' node. Optionally execute nodes connected to the 'End' slot after the schematic finished executing. This only happens when the machine wasn't stopped - use the 'Stop' slot in this case.
- new: Schematic Nodes: Clear Selected Data: 'Clear Selected Data' node available in 'Value > Selected Data' nodes. Clears/removes selected data. Either removes all data of a defined data key, or removes data from all keys (when using an empty data key).
- new: Schematic Nodes: Select Variable Handlers: 'Select Variable Handlers' node available in 'Value > Selected Data' nodes. Uses variable handlers to change selected data. A variable handler stores all variables of an origin, e.g. global variables or object variables of a game object.
- new: Schematic Nodes: Select Components: 'Select Components' nodes available in 'Value > Selected Data' nodes. Uses components to change selected data.
- new: Schematic Nodes: Change Target Frame Rate: 'Change Target Frame Rate' node available in 'Game > Application' nodes. Changes the target frame rate of the application.
- new: Schematic Nodes: Check Target Frame Rate: 'Check Target Frame Rate' node available in 'Game > Application' nodes. Checks the target frame rate of the application.
- new: Schematic Nodes: Remove Component, Enable Component, Is Component Enabled: 'Use Selected Data' settings available in 'Remove Component', 'Enable Component' and 'Is Component Enabled' nodes. Optionally use components stored in selected data instead of defined components of game objects.
- new: Schematic Nodes: Is Object Active: 'Is Object Active' node available in 'Game Object > Game Object' nodes. Checks if a game object is active or inactive.
- new: Schematic Nodes: Restart Schematic: 'Clear Selected Data' setting available. Optionally clears the local selected data of the schematic when restarting it.
- change: Node Editor: Paste Settings: Pasting settings from the clipboard no longer is restricted to the same node type. E.g. pasting settings from a 'Check Variables' node on a 'Change Variables' node will paste over matching settings.
- change: Found Objects: Selected Data: The 'Found Objects' lists for storing game objects locally in schematics have been replaced by 'Selected Data' using the 'Local' data origin. This e.g. affects game object selections and schematic nodes that can store game objects.
- change: Global Objects: Selected Data: The 'Global Objects' lists for storing game objects globally have been replaced by 'Selected Data' using the 'Global' data origin. This e.g. affects game object selections and schematic nodes that can store game objects.
- change: Schematic Nodes: 'Change Found Objects' node has been renamed to 'Select Game Objects'.
- change: Schematic Nodes: 'Filter Found Objects' node has been renamed to 'Filter Selected Game Objects'.
- change: Schematic Nodes: 'Found Objects Count' node has been renamed to 'Selected Game Objects Count'.
- change: Schematic Nodes: 'Found Objects Contain' node has been renamed to 'Selected Game Objects Contain'.
- fix: Editor: Formulas: Fixed an issue where 'List' value types of string values didn't display the list index settings.


Version 1.4.4:
- new: Schematic Nodes: Call Function, Check Function, Store Function Result: 'Transform' parameter type available. Support for Transform parameter types, uses the transform of a defined game object.
- new: Schematic Nodes: Change Position: 'Stop At Target' setting available when moving by speed. Optionally stops the movement when reaching the target, i.e. it can't move past it (e.g. overshooting due to high speed). By default disabled.
- change: Object Changes: The horizontal/vertical speed of a game object will now be measured using the local position change if the game object is parented to another game object. This is e.g. used in the 'Check Speed' node.
- fix: Schematic Nodes: Change Camera Position: Fixed an issue in the 'Change Camera Position' node that stopped the editor from working correctly.
- fix: Schematic Nodes: Rotate Camera Around: Fixed an issue in the 'Rotate Camera Around' node that stopped the editor from working correctly.
- fix: Schematic Nodes: Change Position: Fixed issues with facing the movement direction and moving by speed that caused errors.
- fix: Machines: Fixed an issue where machines always used 'Update' instead of 'Late Update' or 'Fixed Update' update type.


Version 1.4.3:
- new: Editor: Axis Toggles: All toggles managing Vector axes (e.g. 'Ignore Y Distance' for distance checks) have been replaced by a new combined axis toggle setting. Settings that previously only had 1 axis now allow setting all 3 axes, e.g. you can now ignore the distance on all axes instead of only the Y-axis.
- new: Game Settings: 'Start Volume Settings' available in the game settings. Define the music volume and sound volume that will be used when Makinom is initialized.
- new: Interaction Machines: Key Press: 'Start By Root' setting available for the 'Key Press' start type. When using 'In Trigger' or 'While Colliding', the trigger/collision check can be limited to only use the root object.
- new: Schematic Nodes: Rigidbody Constraints: 'Rigidbody Constraints' node available in 'Game Object > Rigidbody' nodes. Changes the constraints of a 'Rigidbody' or 'Rigidbody2D' component.
- change: Editor: Hotkey: The hotkey command to open the Makinom editor now uses the 'M' key instead of the 'O' key. On Windows you can now use CTRL+ALT+M, on Mac OSX you can now use CMD+ALT+M to open the editor.
- fix: Schematic Nodes: Change Position: Fixed an issue when using 'Move' to change a position over time.
- fix: New UI: Fixed an issue where mixing portrait with not-portrait choices could result in images being removed in different GUI boxes afterwards.
- fix: New UI: Fixed an issue where GUI boxes could be displayed with wrong bounds for a frame when opened.
- fix: Game Object Checks: Fixed an issue where checking for a component didn't work correctly (e.g. used by 'Trigger Machine' start by others checks).


Version 1.4.2:
- new: Schematics: Machine Start Variables: 'Machine Start Variables' settings available. Define local start variables (key, type and default value) that will be exposed to machine components for quick and easy setup. Machine components using the schematic will automatically display the defined local start variables.
- new: Machine Components: Local Start Variables: Machine components will automatically load the schematic's 'Machine Start Variables'. First time load uses the default value defined in the schematic. These variables only use simple value fields, if you need more complex settings, disable the start variable in the inspector and add it the usual way to the machine component.
- new: Bool Fields: 'Input Key Button' selection available in all bool field type selections. Uses the current state of an input key's button (true if the button is pressed).
- new: Bool Fields: 'Unity Input Button' selection available in all bool field type selections. Uses the current state of an Unity input's button (true if the button is pressed). The used input's name must match the name defined in the Unity Input Manager.
- new: Float Fields: 'Unity Input Axis' selection available in all float field type selections. Uses the current axis or raw axis value of an Unity input. The used input's name must match the name defined in the Unity Input Manager.
- new: Schematic Nodes: Directional Joystick Input: 'Directional Joystick Input' node available in 'Input' nodes. Stores horizontal and vertical values (e.g. input key axes) transformed by the direction of a game object (e.g. a camera) into a Vector3 variable. E.g. use this for joystick input based on the camera direction.
- new: Schematic Nodes: Move: 'Use Camera Direction' setting available. Optionally transform the horizontal (X-axis) and vertical (Z-axis) values of the move change using the schematic's camera direction.
- new: Schematic Nodes: Set Schematic Camera: 'Set Schematic Camera' node available in 'Game Object > Camera' and 'Machine' nodes. Sets the camera used by the schematic ('Camera' object selection).
- new: Schematic Nodes: Store Initial Camera Position: 'Store Initial Camera Position' node available in 'Game Object > Camera' nodes. Stores the camera's current position, rotation and field of view as initial camera position. You can use the 'Initial Camera Position' node to reset or fade the camera to the initial position.
- fix: Schematic Nodes: Change Time Scale: Fixed an issue where 'Makinom' time origin will set the Unity time scale and 'Unity' time scale will not change any time scale.
- fix: Scene Objects: Fixed an issue where the cursor was displayed outside a scene object when it was parented on something else.
- fix: Schematic Nodes: Follow Path: Fixed an issue when using 'Wait' to wait for the path movement to finish.
- fix: HUDs: Tooltip: Fixed an issue where tooltips of game objects wheren't removed when moving the cursor out of the game object when no other game object was hit by the raycast (e.g. due to not being on a layer checked by the 'HUD Layer Mask').
- fix: Editor: Fixed an issue where updating schematics when saving the Makinom project could throw errors when custom nodes or plugin nodes that no longer exist in the project are used.
- fix: GUI: New UI: Fixed an issue where mixing shadow and outline could result in text flickering.


Version 1.4.1:
- new: Game Controls: Move To Interaction: 'Move To Interaction' settings available in 'Base/Control > Game Controls' in the 'Interaction Settings'. Optionally moves the player to an interaction machine before starting the interaction. Supports simple movement, NavMesh agents and custom move components. Movement can optionally be cancelled.
- new: Interaction Machines: 'Move To Interaction' settings available. Optionally disable 'Move To Interaction' for an interaction machine, or override the default interaction radius and stop distance. Also allows defining a game object as movement destination for the player to move to.
- new: Menu Settings: 'Pixel Drag Threshold' setting available when using the 'New UI' GUI system type. Defines the event system's soft area for dragging in pixels - mostly used for distinguish between touch on a button and dragging when scrolling. 
The best value greatly depends on your used (mobile) device.
- new: Menu Settings, GUI Boxes: OK/Cancel Buttons: 'Content Vertical Alignment' and 'Info Vertical Alignment' settings available in the 'Tabs Settings'. Display the button content at the 'Top', 'Middle' or 'Bottom' of the content area of the button.
- new: GUI Boxes: Content Box: 'Vertical Alignment' setting available in the 'Content Box' settings. Display the content at the 'Top', 'Middle' or 'Bottom' of the content area of the content box.
- new: GUI Boxes: Name Box: 'Vertical Alignment' setting available when not using 'Adjust Height' in the 'Name Box' settings. Display the name content at the 'Top', 'Middle' or 'Bottom' of the content area of the name box.
- new: GUI Boxes: Choice Settings: 'Title Vertical Alignment', 'Content Vertical Alignment' and 'Info Vertical Alignment' settings available in the 'Choice Settings'. Display the title, content and info of choices at the 'Top', 'Middle' or 'Bottom' of the content area of the choice button.
- new: GUI Boxes: Tabs Settings: 'Content Vertical Alignment' and 'Info Vertical Alignment' settings available in the 'Tabs Settings'. Display the tab content at the 'Top', 'Middle' or 'Bottom' of the content area of the tab button.
- new: Scene Objects, Scene Object Types: 'Cursor Change' settings available. Scene objects can optionally change the cursor when the mouse is over the game object with a 'Scene Object' component attached (requires a collider). Scene objects can override the cursor defined in scene object types.
- new: Scene Objects, Scene Object Types: 'Use Object Variable Text Codes' setting available. Optionally uses object variables instead of global variables for game variable text codes in the name and description of scene objects and scene object types.
- new: Scene Object Components: 'Custom Text Codes' settings available. Optionally define custom text codes and the values used to replace them in 'Scene Object' components. They can be used in the names and descriptions of scene objects and scene object types.
- new: HUDs: Tooltip: 'Tooltip' type HUD available. Displays information about a scene object the cursor hovers over.
- new: HUDs: Information: 'Cursor Over' setting available when using 'At Object' in 'Information' type HUDs. Optionally only display the HUD when the cursor is over the HUD user's game object.
- new: HUDs: Interaction: New text codes for 'Interaction' type HUDs available. Display the scene object type's name ('%tn'), description ('%td') or icon ('%ti').
- new: HUDs: Interaction: 'Game State Conditions' settings are now also available in 'Interaction' type HUDs. Optionally only display an interaction HUD when defined game state conditions are valid.
- new: Add HUD Component: The 'Add HUD' component is used to add a game object as a HUD user. Use this component to automatically add a game object as a HUD user, instead of using a schematic with a 'Call HUD' node.
- new: Radius Component: The 'Radius' component is used to define the radius of a game object. The radius is e.g. used when using 'Move to Interaction'  to determine the movement destination.
- new: Float Fields: 'Radius' selection available in all float field type selections. Uses the radius of a game object as value. The radius is either defined by a 'Radius' component, a NavMesh agent or the bounds of a collider.
- new: Float Fields: 'Time Scale' selection available in all float field type selections. Uses the current time scale of Unity, Makinom or the running schematic (only in schematics) as value.
- new: Vector3 Origins: 'Local Position' and 'Local Rotation' selections available. Optionally use the local position/rotation as source of Vector3 values (e.g. in 'Check Transform' or 'Clamp Transform' nodes).
- new: Schematics: 'Delta Time' settings available in the 'Settings' node of schematics. Define if the Unity and Makinom time scale influence the delta time of the schematic.
- new: Schematics: A running schematic now has an internal time scale to influence time-related things (i.e. using delta time). The time scale of the schematic can be changed using 'Change Time Factor' nodes. This e.g. influences movement nodes that use delta time or move over time.
- new: Schematic Nodes: Call Function, Check Function, Store Function Result: 'Enum' parameter type available. Support for enum parameter types, uses an int value as enum value.
- new: Schematic Nodes: Change Fields, Check Fields, Store Field: 'Enum' field/property type available. Support for enum types, uses an int value as enum value.
- new: Schematic Nodes: NavMesh Destination: 'Resume' setting available. Optionally resumes movement of the NavMesh agent. This is needed if the agent was previously stopped to resume movement.
- new: Schematic Nodes: Load Server Scene: 'Load Type' setting available. Defines how the scene will be loaded.
- new: Schematic Nodes: Load Scene: 'Load Async' and 'Load Async Additive' load type selections available. Optionally loads the scene asynchronously in the background.
- new: Schematic Nodes: Change Radius: 'Change Radius' node available in 'Game Object > Game Object' nodes. Changes the radius of a game object. Adds a 'Radius' component if none is added yet.
- new: Formula Nodes: Store Function Result: 'Enum' parameter type available. Support for enum parameter types, uses an int value as enum value.
- new: Formula Nodes: Store Field: 'Enum' field/property type available. Support for enum types, uses an int value as enum value.
- new: Scene Changers: 'Load Async' and 'Load Async Additive' load type selections available. Optionally loads the scene asynchronously in the background.
- change: Scripting: Most enumerations (enum) have been moved from the 'Core' to the 'Gameplay' part of the scripts and can now be changed to your needs.
- change: GUI Boxes: Content Box: The X and Y position of the content box bounds are now used as an offset to the cursor position when using 'At Cursor'.
- change: Schematic Nodes: Replaced most simple float fields with advanced float value selection fields.
- change: Schematic Nodes: Change Time Scale: 'Set Internal Scale' setting has been replaced with 'Time Origin' setting. Allows changing either the 'Unity', 'Makinom' or 'Schematic' (only affecting the schematic it's used in) time scale.
- change: Schematic Nodes: Play Legacy Animation: Multiple settings of the 'Play Legacy Animation' have been updated to use schematic fields. Please check these nodes in your schematics, as not all of them will be updated automatically.
- fix: Portraits: Fixed an issue with choice portraits still being displayed after a different choice was selected (resulting in multiple portraits being displayed at the same time).
- fix: GUI Editor: Fixed an issue where opening the GUI editor after having the Makinom editor open while playing used the play mode's UI scale.
- fix: Editor: Fixed an issue where horizontal scrollbars in the editor where not displayed after opening the GUI editor without a defined GUISkin for the GUI boxes.


Version 1.4.0:
- new: Unity 5.3: Makinom now requires Unity 5.3.
- new: Performance Improvements: There have been performance improvements throughout the entire framework. Depending on your usage of Makinom's features you'll benefit more or less from those improvements.
- new: Game Settings: Performance Settings: 'Performance Settings' available in 'Game > Game Settings'. Settings handling performance optimizations through pooling lists of game objects and variable handlers for reuse.
- new: Music Channels: The volume of each music channel can now be changed individually.
- new: HUDs: Value Bars: 'Display Value' settings available in 'Value Bar' HUD elements. Optionally use a different value to display the bar's current value. This can be used with positive/negative change display in value bars to display the change between the actual value and the displayed value.
- new: HUDs: Interaction: 'At Interaction Position' settings available for 'Interaction' type HUDs. Optionally display the HUD at the position of the interaction's game object.
- new: Value Bars: 'Positive Changes' and 'Negative Changes' settings available in value bar images. Optionally display the difference between the displayed value and the actual value with a different image/color in the value bar.
- new: Menu Settings: 'Mouse Over Selection' settings available. Optionally change the selected choice by hovering the mouse over a choice button.
- new: Schematics: Actors: 'Horizontal Plane' setting available in 'Angle Checks' when using 'Find Object'. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Schematic Nodes: Change Music Volume: 'Use Channel' settings available in 'Change Music Volume' nodes. Optionally change the volume of a defined music channel instead of the master music volume (affecting all channels).
- new: Schematic Nodes: Game Option Dialogue: 'Use Channel' settings available in 'Game Option Dialogue' nodes for 'Music Volume' options. Optionally change the volume of a defined music channel instead of the master music volume (affecting all channels).
- new: Schematic Nodes: Show Dialogue: 'Queued Notification' dialogue type available in 'Show Dialogue' nodes. Displays a message and closes it after time - if another queued notification is displayed, the dialogue will be displayed after all previous queued notifications are closed. You can separate notification queues by using different queue keys.
- new: Schematic Nodes: Show Dialogue: 'Title' settings available when not showing a speaker's name in 'Show Dialogue' nodes. Optionally display a defined title in the name box of the used GUI box. You can use the text code '%n' to add the name of a speaker to the title.
- new: Schematic Nodes: Game Option Dialogue: 'Title' settings available when not showing a speaker's name in 'Game Option Dialogue' nodes. Optionally display a defined title in the name box of the used GUI box. You can use the text code '%n' to add the name of a speaker to the title.
- new: Schematic Nodes: Language Dialogue: 'Title' settings available when not showing a speaker's name in 'Language Dialogue' nodes. Optionally display a defined title in the name box of the used GUI box. You can use the text code '%n' to add the name of a speaker to the title.
- new: Schematic Nodes: Start Machine, Start Tagged Machine: 'Limit Starts per Frame' settings available when not using 'Time Between'. Optionally limit the number of machines started in a single frame. Use this option when starting a lot of machines to prevent stack overflow exceptions.
- new: Schematic Nodes: Start Tagged Machine: 'Scope' setting available. Define the scope of tagged machines on a game object that will be used. Defaults to 'All In Children' (i.e. using all tagged machines attached to the game object and any of its child objects).
- new: Schematic Nodes: Change Found Objects: 'Filter Game Objects' settings available. Game objects used to change a found/global objects list can optionally be filtered before using them to change the list.
- new: Schematic Nodes: Orientation Fork: 'Orientation Fork' node available in 'Movement > Rotation' nodes. Checks the orientation from objects to other objects (e.g. if an object is in front of another object). The next slot of the according orietnation will be executed next, e.g. if an object is in front of another object, the 'Front' slot will be executed next.
- new: Schematic Nodes: Check Angle, Check Orientation: 'Horizontal Plane' setting available. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Schematic Nodes: Search Objects, Filter Found Objects, Raycast, Shapecast, Check Shape: 'Horizontal Plane' setting available in 'Angle Checks'. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Formulas: Check Orientation, Angle, Check Angle: 'Horizontal Plane' setting available. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- new: Machine Components: 'Horizontal Plane' setting available in orientation checks. Defines the axes that will be used as horizontal plane (i.e. horizontal movement of the game objects), either XZ (default 3D behaviour) or XY (default 2D behaviour).
- change: Schematic Nodes: Show Dialogue: Displaying a 'Choice' type dialogue without adding choices will now display a warning in the Unity console.
- change: Machine Components: The used schematic asset is now loaded into a working schematic when the scene is loaded or the game object is instantiated instead of the first time the schematic is played. This reduces the time needed to start the schematic.
- fix: Editor: Global Machines: Fixed an issue where additional settings of global machines wheren't displayed.
- fix: GUI Editor: Fixed an issue when opening HUDs in the GUI editor.
- fix: Text Codes: Fixed an issue where some text codes (e.g. for changing text color) could add an additional space to the text.
- fix: HUDs: Fixed an issue where the name box of HUDs didn't show after the HUD was closed and opened again when using the new UI.
- fix: iOS: Fixed an issue where running a project in XCode on iOS resulted in a crash.
- fix: New UI: Fixed an issue when updating content of a scrollable GUI box that caused text/images to be hidden.
- fix: Variables: Using the 'Replace' operator for string variable changes will now correctly replace the first occurence instead of all occurences.


Version 1.3.0:
- new: Grids: Create, manage and manipulate grids of game objects in the new 'Grid' schematic nodes (found at 'Game Object > Grid'). Use them for creating level architecture, gameplay, effects or other things.
- new: Music Channels: Play different music clips at the same time using music channels. Each channel can play one clip at a time and fade between clips. The default channel is 0.
- new: Music: Stored Music: You can now store different currently playing clips per channel using IDs. As before, you can store the currently playing clip and playback time of a music channel, but you can separate multiple stored clips using stored IDs and playback them at a later time.
- new: Music Player: 'Music Channel' setting available in the 'Music Player' component. Defines the music channel that will be used to play or change the music.
- new: Game Object Fields: 'Grid Root' and 'Grid Cell' selections available in all game object field type selections. Uses the root game object of a grid or the game objects of grid cells as game objects.
- new: Float Fields: 'Grid Size' and 'Grid Max Index' selections available in all float field type selections. Uses a defined axis of a grid's size or maximum index.
- new: Vector3 Fields: 'Grid Size' and 'Grid Max Index' selections available in all Vector3 field type selections. Uses the size or maximum index of a grid.
- new: Vector3 Fields: 'Grid Object Index' selection available in all Vector3 field type selections. Uses the index of a defined game object in a grid (if found, otherwise X=-1, Y=-1, Z=-1).
- new: Vector3 Fields: 'Grid Cell Position' and 'Grid Cell Rotation' selections available in all Vector3 field type selections. Uses the world position or rotation of a grid cell.
- new: Schematic Nodes: Create Grid: 'Create Grid' node available in 'Game Object > Grid' nodes. Creates a game object grid.
- new: Schematic Nodes: Change Grid Size: 'Change Grid Size' node available in 'Game Object > Grid' nodes. Changes the size of a grid and optionally destroys game objects of removed grid cells.
- new: Schematic Nodes: Remove Grid: 'Remove Grid' node available in 'Game Object > Grid' nodes. Removes a grid and optionally destroys all game objects of the grid cells.
- new: Schematic Nodes: Remove Grid Cell: 'Remove Grid Cell' node available in 'Game Object > Grid' nodes. Removes the game objects of grid cells and optionally destroys them.
- new: Schematic Nodes: Grid Exists: 'Grid Exists' node available in 'Game Object > Grid' nodes. Checks if a game object grid exists for a defined key.
- new: Schematic Nodes: Fill Grid Cells: 'Fill Grid Cells' node available in 'Game Object > Grid' nodes. Fills grid cells with prefab instances.
- new: Schematic Nodes: Set Grid Cell: 'Set Grid Cell' node available in 'Game Object > Grid' nodes. Assigns game objects to grid cells.
- new: Schematic Nodes: Swap Grid Cell: 'Swap Grid Cell' node available in 'Game Object > Grid' nodes. Swaps game objects assigned to grid cells between 2 defined grids. Optionally animated through interpolation or starting machines.
- new: Schematic Nodes: Move Grid Cell: 'Move Grid Cell' node available in 'Game Object > Grid' nodes. Moves game objects of grid cells within the grid. Optionally animated through interpolation or starting machines.
- new: Schematic Nodes: Can Move Grid Cell: 'Can Move Grid Cell' node available in 'Game Object > Grid' nodes. Checks if game objects of grid cells can be moved within the grid.
- new: Schematic Nodes: Block Grid Cells: 'Block Grid Cells' node available in 'Game Object > Grid' nodes. Blocks or unblocks cells of a grid. Blocked grid cells can't be changed (e.g. set to a different game object).
- new: Schematic Nodes: Is Grid Cell Blocked: 'Is Grid Cell Blocked' node available in 'Game Object > Grid' nodes. Checks if a grid cell is blocked.
- new: Schematic Nodes: Hide Grid Cells: 'Hide Grid Cells' node available in 'Game Object > Grid' nodes. Hides or unhides cells of a grid. Game objects of hidden grid cells are disabled.
- new: Schematic Nodes: Is Grid Cell Hidden: 'Is Grid Cell Hidden' node available in 'Game Object > Grid' nodes. Checks if a grid cell is hidden.
- new: Schematic Nodes: Is Grid Cell Empty: 'Is Grid Cell Empty' node available in 'Game Object > Grid' nodes. Checks if a grid cell is empty (i.e. no game object is assigned to the cell).
- new: Schematic Nodes: Is Grid Cell Object: 'Is Grid Cell Object' node available in 'Game Object > Grid' nodes. Checks if game objects are part of a grid.
- new: Schematic Nodes: Change Music: 'Music Channel' setting available in 'Change Music' nodes. Defines the music channel that will change the music.
- new: Schematic Nodes: Change Music: 'Stored ID' setting available in 'Change Music' nodes when playing a stored clip. Defines the ID of the stored clip that will be played.
- new: Schematic Nodes: Store Music: 'Music Channel' setting available in 'Store Music' nodes. Defines the music channel that will store it's currently playing music.
- new: Schematic Nodes: Store Music: 'Stored ID' setting available in 'Store Music' nodes. Defines the stored ID used to store the clip for later playback.
- new: Schematic Nodes: Change Playback Position: 'Music Channel' setting available in 'Change Playback Position' nodes. Defines the music channel that will change it's playback position.
- new: Schematic Nodes: Is Music Playing: 'Is Music Playing' node available in 'Animation + Audio > Music' nodes. Checks if a defined music channel or any channel is currently playing music or a defined music clip.
- new: Schematic Nodes: Clear Spawned Prefabs: 'Clear Spawned Prefabs' node available in 'Game Object > Prefab' nodes. Removes references to spawned prefab instances, the game objects can no longer be accessed using the 'Spawned Prefab ID'.
- new: Schematic Nodes: Spawn Prefab: 'Keep Reference' option available in 'Spawn Prefab' nodes. Keeping track of the prefab instance through the 'Spawned Prefab ID' is now optional. By default enabled.
- new: Schematic Nodes: Start Machine: 'Use Same Object' setting available in 'Start Machine' nodes. Optionally uses the same game object as used for the 'Machine Object' as starting object. Otherwise (e.g. when selecting the same game object) every possible combination of machine and starting object will be used.
- new: Schematic Nodes: Start Tagged Machine: 'Use Same Object' setting available in 'Start Tagged Machine' nodes. Optionally uses the same game object as used for the 'Machine Object' as starting object. Otherwise (e.g. when selecting the same game object) every possible combination of machine and starting object will be used.
- change: Schematic Nodes: Music Nodes: Music related nodes can now be found in 'Animation + Audio > Music' instead of 'Animation + Audio/Audio'.
- change: Input Keys: Gyroscope: The device gyroscope is now automatically enabled when a 'Gyroscope' input key is set up.
- change: Game Controls: The default 'Max Mouse Distance' is now -1 for new projects. I.e. interaction machines with mouse start types will not check the distance to the player by default.
- change: Schematic Nodes: Start Machine: Greatly improved performance when starting a lot of machines.
- fix: New UI: Scrolling: Fixed an issue where dragging on an empty part of a scrolling area didn't scroll.
- fix: Auto Machines: Fixed an issue with 'Disable' and 'Destroy' start types not working correctly.


Version 1.2.1:
- new: Input Keys: Input IDs: You can now define multiple input settings per input key, which are assigned to an 'Input ID'. This allows creating different control styles or local multiplayer games without having to change the input keys used in machines/schematics. The global input ID (0 at the start of the game) can be changed or overridden by each started machine.
- new: Input Keys: 'Use Absolute Value' setting available for button press recognition of 'Acceleration' and 'Gyroscope' inputs. Optionally uses the absolute value of the axis (i.e. -0.2 will become 0.2 for the check) when checking for button input. By default enabled.
- new: Input Keys: 'Axis Factor' setting available. The input axis value will be multiplied by this value. By default 1.
- new: Input Keys: 'Limit Axis' settings available. Optionally limit the axis value to be between 2 defined values (e.g. -1 and 1). By default disabled.
- new: Machine Components: Machine Execution Settings: 'Input ID' settings available. Optionally define a different input ID to be used by the machine, otherwise the global input ID will be used. Input keys used in the started schematic will rely on the used input ID.
- new: Global Events: 'Input ID' settings available. Optionally define a different input ID to be used by the machine, otherwise the global input ID will be used. Input keys used in the started schematic will rely on the used input ID.
- new: HUDs: Display Conditions: 'Input ID' settings available when using a toggle key. Optionally define a different input ID to be used by the input key, otherwise the global input ID will be used.
- new: HUDs: Control: 'Input ID' settings available in 'Control' HUD elements. Optionally define a different input ID to be used by the input key, otherwise the global input ID will be used.
- new: Save Game Menu: Save Settings: 'Input ID' setting available. Optionally saves the global input ID - the globa input ID can be changed in-game to create different control styles. By default enabled.
- new: Editor Settings: 'Highlight Value Fields' setting available. Optionally highlights advanced value fields consisting of multiple fields/selections to mark which fields belong together. This is used by string, bool, float and Vector3 value fields that allow using different value origins (e.g. variables). By default enabled.
- new: String Fields: String Types: 'Game Object Name' and 'Game Object Tag' selections available in all string field type selections. Uses the name or tag of a defined game object as string value.
- new: Float Fields: 'Global Input ID' and 'Local Input ID' selections available in all float field type selections. Uses the global input ID or locally used input ID (e.g. in a schematic or a formula called by a schematic) as value.
- new: Float Fields: Math Functions: 'Direction 360', 'Direction 4' and 'Direction 8' selection available in all float field math function selections. Translates the value into a direction angle (0-360), a 4-directional value (0-3, int) or an 8-directional value (0-7, int).
- new: Vector3 Fields: 'Gravity 3D' and 'Gravity 2D' selections in all Vector3 field type selections. Uses the 3D physics or 2D physics gravity as value.
- new: Vector3 Fields: 'Vector3 Variable' type now supports advanced string fields for variable key definition.
- new: Schematics: Actors: 'Filter' search type selection available for 'Game Object' actor types using 'Find Object'. Optionally search for objects using advanced filter options.
- new: Schematic Nodes: Change Input ID: 'Change Input ID' node available in 'Input' nodes. Changes the global input ID or the schematic's input ID.
- new: Schematic Nodes: Check Input ID: 'Check Input ID' node available in 'Input' nodes. Checks the global input ID or the schematic's input ID.
- new: Schematic Nodes: Start Machine: 'Input ID' settings available in 'Start Machine' nodes. Optionally define a different input ID to be used by the machine, otherwise the schematic's input ID will be used. Input keys used in the started schematic will rely on the used input ID.
- new: Schematic NOdes: Start Global Machine: 'Input ID' settings available in 'Start Global Machine' nodes. Optionally override the input ID of the called global machine.
- new: Schematic Nodes: Add Machine To Stack: 'Input ID' settings available in 'Add Machine To Stack' nodes. Optionally define a different input ID to be used by the machine, otherwise the schematic's input ID will be used. Input keys used in the started schematic will rely on the used input ID.
- new: Schematic Nodes: Input Key: 'Input ID' settings available in 'Input Key' nodes. Optionally define a different input ID to check the input key, otherwise the schematic's input ID will be used.
- new: Schematic Nodes: Search Objects: 'Filter' search type selection available in 'Search Object' nodes. Optionally search for objects using advanced filter options.
- new: Schematic Nodes: Change Found Objects: 'Change Found Objects' node available in 'Game Object > Game Object' nodes. Adds or removes a game object to/from a 'Found Objects' or 'Global Objects' list.
- new: Schematic Nodes: Sort Variable List: 'Random' sort type selection available. Randomly sorts a variable lists.
- new: Schematic Nodes: Variable List Contains: 'Variable List Contains' node available in 'Value > Variable' nodes. Checks if variable lists contain defined values. Float, Vector3 and axis Vector3 checks for approximate values (i.e. being very close to the defined value).
- new: Schematic Nodes: Unload Scene: 'Unload Scene' node available in 'Game > Scene' nodes. Unloads all game objects associated with a defined scene name.
- new: Schematic Nodes: Unload Unused Assets: 'Unload Unused Assets' node available in 'Game > Game' nodes. Unloads assets that are not used.
- new: Schematic Nodes: Stop Machine Component: 'All' setting available in 'Stop Machine Component' nodes. Optionally stops all available machine components in the scene.
- new: Schematic Nodes: Stop Tagged Machine: 'Stop Tagged Machine' node available in 'Machine' nodes. Stops tagged machine components added to a game object that are matching the defined tags.
- new: Schematic Nodes: Search Tagged Machines: 'Search Tagged Machines' node available in 'Machine' nodes. Searches for game objects with 'Tagged Machine' components (using defined tags) in the scene and adds/removes them to/from a 'Found Objects' or 'Global Objects' list.
- new: Schematic Nodes: Rotation Nodes: 'Local Rotation' setting available when using 'Transform' rotation component and 'Set' rotation function in various nodes in 'Movement > Rotation' nodes. Optionally sets the local rotation of the transform, this can be useful when rotating mounted game objects.
- change: Find Object Settings: The range settings for finding objects have been replaced by advanced range settings. You can now search for 'In Range' and 'Out of Range', and use advanced float value fields (e.g. formulas).
- change: Find Object Settings: The name/tag settings for finding objects have been replaced by advanced name settings. You can now check if the name/tag is equal, starts with, ends with or contains a defined string value, as well as negate that check.
- change: Schematic Nodes: Movie Textures: The 'Movie Texture' nodes have been moved into a separate plugin. This was needed due to movie textures not being supported on iOS. If you're using 'Movie Texture' nodes in your schematics, just download the new 'Movie Textures Plugin' at makinom.com/plugins/ and import it into your Unity project.
- fix: Collision Machines, Trigger Machines: 'Start By Other' object checks (e.g. for a game object's name) needing only 'One' condition to be valid could result in always being valid.


Version 1.2.0:
- new: Unity 5.2: Makinom now requires Unity 5.2.
- new: Machine Stacks: Machine stacks are now available. You can add machines/schematics to a machine stack and execute them in the order they're added to the stack. You can separate machine stacks by using keys to identify them. Machine stacks are used in schematics, see 'Machine > Machine Stack' nodes for details.
- new: GUI Boxes: Move In/Out: 'Relative Move' settings available in 'Move In' and 'Move Out' settings. Optionally define the 'Start Position' or 'End Position' relative to the bounds of the content box.
- new: GUI Boxes: Move In/Out: 'Use Curve' settings available in 'Move In' and 'Move Out' settings. Optionally use animation curves for scaling the GUI box in or out. This allows more complex scaling operations, e.g. bouncing.
- new: GUI Boxes: 'Screen Adjustment' settings available. Optionally adjust the position of the GUI box to fit the content box within the screen space. Use this e.g. for GUI boxes that follow the mouse cursor.
- new: Schematic Nodes: Start Machine Stack: 'Start Machine Stack' node available in 'Machine > Machine Stack' nodes. Starts a machine stack. The machines on the machine stack will be executed in the order they're added.
- new: Schematic Nodes: Stop Machine Stack: 'Stop Machine Stack' node available in 'Machine > Machine Stack' nodes. Stops a machine stack's execution.
- new: Schematic Nodes: Remove Machine Stack: 'Remove Machine Stack' node available in 'Machine > Machine Stack' nodes. Removes a machine stack. If the stack is currently executing, the stack will be stopped.
- new: Schematic Nodes: Clear Machine Stack: 'Clear Machine Stack' node available in 'Machine > Machine Stack' nodes. Removes all machines added to a machine stack.
- new: Schematic Nodes: Reverse Machine Stack: 'Reverse Machine Stack' node available in 'Machine > Machine Stack' nodes. Reverses the order of machines in a machine stack.
- new: Schematic Nodes: Shuffle Machine Stack: 'Shuffle Machine Stack' node available in 'Machine > Machine Stack' nodes. Randomly sorts the machines in a machine stack.
- new: Schematic Nodes: Add Machine To Stack: 'Add Machine To Stack' node available in 'Machine > Machine Stack' nodes. Adds a schematic/machine to a machine stack.
- new: Schematic Nodes: Remove From Stack: 'Remove From Stack' node available in 'Machine > Machine Stack' nodes. Removes a machine from a machine stack. The machine is identified by it's index on the stack.
- new: Schematic Nodes: Remove Schematic From Stack: 'Remove Schematic From Stack' node available in 'Machine > Machine Stack' nodes. Removes a machine from a machine stack. The machine is identified through the used schematic asset.
- new: Schematic Nodes: Remove Object From Stack: 'Remove Object From Stack' node available in 'Machine > Machine Stack' nodes. Removes a machine from a machine stack. The machine is identified through the machine object or starting object.
- new: Schematic Nodes: Is Machine Stack Running: 'Is Machine Stack Running' node available in 'Machine > Machine Stack' nodes. Checks if a machine stack is currently running.
- new: Schematic Nodes: Machine Stack Exists: 'Machine Stack Exists' node available in 'Machine > Machine Stack' nodes. Checks if a machine stack exists.
- new: Schematic Nodes: Machine Stack Count: 'Machine Stack Count' node available in 'Machine > Machine Stack' nodes. Checks the number of machines in a machine stack.
- new: Schematic Nodes: Stack Contains Schematic: 'Stack Contains Schematic' node available in 'Machine > Machine Stack' nodes. Checks if a schematic asset is used in a machine stack.
- new: Schematic Nodes: Stack Contains Object: 'Stack Contains Object' node available in 'Machine > Machine Stack' nodes. Checks if a game object is used as machine/starting object in a machine stack.
- new: Schematic Nodes: Delete Auto Save: 'Delete Auto Save' node available in 'Game > Save Game' nodes. Deletes the AUTO save slot's save game or the temporary retry save game.
- new: Schematic Nodes: Delete Save Game: 'Delete Save Game' node available in 'Game > Save Game' nodes. Deletes a defined save game or AUTO save game.
- new: Schematic Nodes: Is Visible: 'Is Visible' node available in 'Game Object > Renderer' nodes. Checks if a game object's renderer is visible by any camera.
- new: Schematic Nodes: Found Objects Contain: 'Found Objects Contain' node available in 'Game Object > Game Object' nodes. Checks if a game object is stored in a found objects or global objects list.
- new: Schematic Nodes: Stop Machine Component: 'Stop Machine Component' node available in 'Machine' nodes. Stops machine components attached to a game object.
- change: GUI Boxes: 'Fade In/Out' and 'Move In/Out' settings have been rearranged into 'Open Box Behaviour' and 'Close Box Behaviour'. Scaling in/out can now be done independent of moving in/out.
- change: New UI: When not using a texture mask, the new 'Rect Mask 2D' component will be used for masking content. This reduces draw calls and increses performance.
- fix: Save Games: Loading a game could cause an error due to not clearing object variables first.


Version 1.1.1:
- new: Networking Settings: 'Max Server Connections' setting available. Defines the maximum allowed connections to the server.
- new: Auto Machines: Start Settings: 'Network Destroy' UNET start type available. Use this start type when a game object is destroyed through the server. Requires a 'Network Forward' component attached to the game object to receive network callbacks.
- new: Auto Machines: Start Settings: 'Start Authority' UNET start type available. Similar to 'Start', but only started when the game object has authority. Requires a 'Network Forward' component attached to the game object to receive network callbacks.
- new: Auto Machines: Start Settings: 'Start Client' UNET start type available. Similar to 'Start', but only started on a client. Requires a 'Network Forward' component attached to the game object to receive network callbacks.
- new: Auto Machines: Start Settings: 'Start Local Player' UNET start type available. Similar to 'Start', but only started when the game object is the local player. Requires a 'Network Forward' component attached to the game object to receive network callbacks.
- new: Auto Machines: Start Settings: 'Start Server' UNET start type available. Similar to 'Start', but only started on a server. Requires a 'Network Forward' component attached to the game object to receive network callbacks.
- new: Animation State Machines: Start Settings: 'Networking Conditions' settings available. Optionally check the machine object for UNET conditions (e.g. if the machine object is the local player) or if server or client are active.
- new: Schematic Nodes: Start Tagged Machine: 'Network Start' setting available. Optionally starts tagged machines on the server. All used machine objects and starting objects must have a 'NetworkIdentity' component attached and must be spawned by the server.
- new: Schematic Nodes: Disconnect All Clients: 'Disconnect All Clients' node available in 'Networking > Server' nodes. Disconnects all clients currently connected to the UNET server.
- new: Schematic Nodes: Check Network Active: 'Check Network Active' node available in 'Networking > Networking' nodes. Checks if server or client are active.
- new: Schematic Nodes: Check Network Object: 'Check Network Object' node available in 'Networking > Networking' nodes. Checks a game object for UNET networking conditions.
- change: Schematic Nodes: Stop Server: 'Stop Server' can now also be called on clients connected to the server.
- fix: HUDs: Fixed an issue with HUD element positioning relative to other HUD elements when using the new UI.


Version 1.1.0:
- new: Unity 5.1.2: Makinom now requires Unity 5.1.2 and supports UNET networking functionality.
- new: Networking Settings: 'Networking Settings' sub-section available in the 'Game' section. Define UNET networking/multiplayer functionality for Makinom, e.g. automatic game state and variable synchronization.
- new: Network Machines: UNET start types available.
- new: Machine Components: Start Settings: 'Networking Conditions' settings available. Optionally check the machine object and starting object for UNET conditions (e.g. if the machine object is the local player) or if server or client are active.
- new: Game States: 'Network Synchronize' setting available. Optionally allows synchronizing a game state between server and all clients. Synchronization happens either through enabling game state synchronization in the 'Networking Settings' or using 'Synchronize Game States' nodes in schematics.
- new: Schematic Nodes: Start Server: 'Start Server' node available in 'Networking > Server' nodes. Starts a UNET server.
- new: Schematic Nodes: Stop Server: 'Stop Server' node available in 'Networking > Server' nodes. Stops a UNET server.
- new: Schematic Nodes: Is Server Active: 'Is Server Active' node available in 'Networking > Server' nodes. Checks if a UNET server is active in the application.
- new: Schematic Nodes: Load Server Scene: 'Load Server Scene' node available in 'Networking > Server' nodes. Loads a scene on the server, causing all connected clients to also load the scene.
- new: Schematic Nodes: Start Client: 'Start Client' node available in 'Networking > Client' nodes. Starts a UNET client and connects to a server.
- new: Schematic Nodes: Stop Client: 'Stop Client' node available in 'Networking > Client' nodes. Stops a UNET client.
- new: Schematic Nodes: Set Client Ready: 'Set Client Ready' node available in 'Networking > Client' nodes. Sets a UNET client to be ready and notifies the server.
- new: Schematic Nodes: Is Client Active: 'Is Client Activey' node available in 'Networking > Client' nodes. Checks if a UNET client is active in the application.
- new: Schematic Nodes: Is Client Connected: 'Is Client Connected' node available in 'Networking > Client' nodes. Checks if a UNET client is connected in this application.
- new: Schematic Nodes: Is Client Ready: 'Is Client Ready' node available in 'Networking > Client' nodes. Checks if a UNET client is ready in this application.
- new: Schematic Nodes: Synchronize Game States: 'Synchronize Game States' node available in 'Networking > Synchronize' nodes. Synchronizes game states between server and client - either gets the game states from the server or sends the client's game states to the server. Can be used when not using automatic game state synchronization.
- new: Schematic Nodes: Synchronize Variables: 'Synchronize Variables' node available in 'Networking > Synchronize' nodes. Synchronizes global or object variables between server and client - either gets the variables from the server or sends the client's variables to the server. Can be used when not using automatic variable synchronization.
- new: Schematic Nodes: Spawn Player: 'Network Spawn' setting available. Optionally spawns the player on the server and all clients. The player's prefab must have a 'NetworkIdentity' component attached at the root and be registered for spawning.
- new: Schematic Nodes: Destroy Player: 'Network Destroy' setting available. Optionally destroys the player on the server and all clients. The player's game object must have a 'NetworkIdendity' component attached and must've been spawned by the server.
- new: Schematic Nodes: Set Player: 'Network Set' setting available. Optionally sets the player for the client and informs the server. The game object must have a 'NetworkIdentity' component attached and must've been spawned by the server.
- new: Schematic Nodes: Spawn Prefab: 'Network Spawn' setting available. Optionally spawns the prefab on the server and all clients. The prefab must have a 'NetworkIdentity' component attached at the root and be registered for spawning.
- new: Schematic Nodes: Destroy Prefab: 'Network Destroy' setting available. Optionally destroys the prefab on the server and all clients. The prefab must have a 'NetworkIdentity' component attached an must've been spawned by the server.
- new: Schematic Nodes: Activate Object: 'Network Activate' setting available. Optionally activates/inactivates the game object on the server and all clients. The game object must have a 'NetworkIdentity' component attached an must've been spawned by the server.
- new: Schematic Nodes: Destroy Object: 'Network Destroy' setting available. Optionally destroys the game object on the server and all clients. The game object must have a 'NetworkIdentity' component attached an must've been spawned by the server.
- new: Schematic Nodes: Function Nodes: 'Component' parameter type available. You can now use a component of a game object as parameter for function calls and field/property changes and checks.
- new: Schematic Nodes: Raycast Nodes: 'Distance Checks' and 'Angle Checks' settings available in 'Filter Game Objects' settings. Optionally filter the hit game objects by checking distance and angle to other game objects.
- new: Schematic Nodes: Filter Found Objects: 'Filter Found Objects' node available in 'Game Object > Game Object' nodes. Filters the found objects or global objects list by name/tag/component, distance, angle and excluded objects.
- new: Schematic Nodes: Found Objects Count: 'Found Objects Count' node available in 'Game Object > Game Object' nodes. Checks the number of game objects stored in the found objects or global objects list.
- new: Schematic Nodes: Load Scene: 'Scene Origin' setting available. Select where the scene originates that will be loaded - either a defind scene, a stored scene or the current scene of a server.
- change: Schematic Nodes: Search Objects: 'Search Origin' setting now uses a Vector3 instead of a game object when searching within a defined radius. This still allows using a game object as source position. Old settings will be updated automatically.
- fix: GUI Boxes: Dragging a GUI box ('Drag Settings' settings) now works correctly.
- fix: Schematic Nodes: Start Tagged Machines: Disabled tagged machine components will no longer be started by the 'Start Tagged Machine' node.
- fix: Schematic Nodes: Start Tagged Machines: Starting tagged machine componentss could in some cases cause errors.


Version 1.0.4:
- new: Texture Fields: All 'Texture' selection fields now support all kinds of texture assets. Besides 'Texture2D' (default till now), you can e.g. also use 'RenderTexture' (rendering a camera to a texture), 'MovieTexture'.
- new: Store Terrain Changes Component: 'Store Terrain Changes' component available in 'Makinom > Scenes'. Stores changes to a terrains heightmap or alphamap using an object ID. The changes can be saved with save games.
- new: Save Game Menu: Save Settings: 'Terrain Changes' setting available. Select if terrain changes are remembered in the running game or in save games. Warning: This will dramatically increase the save game data.
- new: Global Objects: You can now store multiple sets of different objects by using different keys. An 'Object Key' setting is available when storing or using 'Global Objects'.
- new: Schematics: Found Objects: You can now store multiple sets of different objects by using different keys. An 'Object Key' setting is available when storing or using 'Found Objects'.
- new: Schematic Nodes: Camera Target Texture: 'Camera Target Texture' node available in 'Game Object > Camera' nodes. Changes the target texture of a camera - the camera will render into the defined texture. Requires a 'RenderTexture' asset to be used.
- new: Schematic Nodes: Play Movie Texture: 'Play Movie Texture' node available in 'Animation + Audio > Movie Texture' nodes. Starts playing the movie of a 'MovieTexture', either of a defined asset or on a game object (e.g. renderer, UI component).
- new: Schematic Nodes: Pause Movie Texture: 'Pause Movie Texture' node available in 'Animation + Audio > Movie Texture' nodes. Pauses playing the movie of a 'MovieTexture', either of a defined asset or on a game object (e.g. renderer, UI component).
- new: Schematic Nodes: Stop Movie Texture: 'Stop Movie Texture' node available in 'Animation + Audio > Movie Texture' nodes. Stops playing the movie of a 'MovieTexture' and rewinds it back to the beginning, either of a defined asset or on a game object (e.g. renderer, UI component).
- new: Schematic Nodes: Is Movie Ready: 'Is Movie Ready' node available in 'Animation + Audio > Movie Texture' nodes. Checks if the movie of a 'MovieTexture' is ready for playing.
- new: Schematic Nodes: Is Movie Playing: 'Is Movie Playing' node available in 'Animation + Audio > Movie Texture' nodes. Checks if the movie of a 'MovieTexture' is playing.
- fix: New UI: Portraits: Displaying a portrait behind a GUI box now works correctly.
- fix: Schematic Nodes: Image Nodes: Images now scale and position correctly when using the new UI.
- fix: Variables: Fixed an issue where Vector3 and list variables haven't been saved correctly.


Version 1.0.3:
- new: Unity 5.1: Makinom now requires Unity 5.1.
- new: Update UI Text Components: 'Update UI Text' component available. Updates the text of a selected 'Text' component. Can use text codes to show Makinom information (e.g. variables) and special text codes to display scene object information (e.g. name, description).
- new: Update UI Slider Components: 'Update UI Slider' component available. Updates the value (and min/max values) of a selected 'Slider' component. Can use float values (e.g. from variables, inputs, etc.).
- new: Machine Components: 'Auto Stop Machine' settings available. Optionally continue to check the machine's start conditions in running schematics and stop them if the conditions are invalid.
- new: Animation Machines: 'Animation Event' start type available. Use this start type when you want to start the animation machine from animation events or using UI UnityEvents. Use the 'AnimationEvent' function (without parameters) to start the machine.
- new: Animation Machines: 'UI Game Object' start type available. Starts when used by UI components firing UnityEvents with a GameObject parameter.
- new: Menu Settings: 'Default Mask Texture' setting available. Select the material that will be used for texture masks. Can optionally be overridden by each image that uses texture masks.
- new: Schematic Nodes: Is On NavMesh: 'Is On NavMesh' node available. Checks if a NavMesh agent is currently bound to a NavMesh.
- new: Schematic Nodes: Store Sample Position: 'Store Sample Position' node available in 'Movement > NavMesh' nodes. Stores the closest position on a NavMesh within a defind range of a source position into a Vector3 variable.
- new: Schematic Nodes: Raycast, Shapecast: 'Store On Hit Object' setting available. Optionally store variables (e.g. the hit point) in object variables on the game object that was hit by the cast.
- new: Schematic Nodes: Raycast, Shapecast: Additional hit information can be stored into variables. Optionally store 3D (e.g. barycentric coordinates) and 2D (e.g. centroid) hit information.
- new: Schematic Nodes: Check Start Conditions: 'Check Start Conditions' node available in 'Machine' nodes. Checks the start conditions (e.g. game state conditions, variable conditions) of the machine that started the schematic. If the schematic wasn't started by a machine, the check is always valid.
- new: Schematic Nodes: Is Terrain: 'Is Terrain' node available in 'Game Object > Terrain' nodes. Checks if a game object is a terrain.
- new: Schematic Nodes: Is In Terrain Space: 'Is In Terrain Space' node available in 'Game Object > Terrain' nodes. Checks if a position is within a terrain's space. The position can be defind in world space, terrain space, alpha map and height map position. A position is in a terrain's space if all axes of the converted position are between 0 and 1.
- new: Schematic Nodes: Transform Terrain Space: 'Transform Terrain Space' node available in 'Game Object > Terrain' nodes. Transforms a position to or from terrain space and stores the result into a Vector3 variable. The position can be defind and transformed to world space, terrain space, alpha map or height map position.
- new: Schematic Nodes: Change Terrain Height: 'Change Terrain Height' node available in 'Game Object > Terrain' nodes. Changes the height of a terrain (heightmap) at a defined position.
- new: Schematic Nodes: Terrain Texture Fork: 'Terrain Texture Fork' node available in 'Game Object > Terrain' nodes. Checks the main texture at a position on a terrain. If a texture matches, it's next node will be executed.
- new: Schematic Nodes: Change Terrain Alpha Map: 'Change Terrain Alpha Map' node available in 'Game Object > Terrain' nodes. Changes the alpha value of a defined texture index of a terrain at a defind position.
- change: Images: Texture Masks: Due to creating materials through a shader in string form is deprecated, the 'Alpha Mask Texture' setting has been removed in all image settings. You now have to use a material instead, either define a default material in 'Menus > Menu Settings' or in the image's settings.
- fix: Global Machines: Fixed an issue with global machines not starting when using 'Start Game' in the game starter.
- fix: Animation Machines: Fixed some issues with the new 'Animation Event' start types.
- fix: Auto Machines: Fixed an issue with 'Repeat Execution' isn't repeated after failed game state checks.
- fix: Machine Component Inspectors: Fixed an issue where creating a new schematic when the machine already had a schematic selected opened the old schematic.


Version 1.0.2:
- new: Node Editor: You can now select, edit, delete, move, copy and clipboard copy/paste multiple nodes. To select multiple nodes, hold the shift key while clicking on them.
- new: Node Editor: 'Paste Settings' button and context menu option (on node) available after copying a node to the clipboard. Pastes the settings of a node on another node - only available when both nodes are of the same type.
- new: Animation Machines: 'Animation Event Int', 'Animation Event Float' and 'Animation Event String' start types available. Use these start types when you want to start the animation machine fron animation events. Optionally allows checking the int/float/string parameter that was passed on from the animation.
- new: Collision Machines, Trigger Machines, Scene Changers: 'Start By Root' setting available. Optionally starts the machine only when the starting object's root object causes the collision/trigger event. By default disabled.
- new: Input Keys: Unity Input Manager: 'Is Joypad Axis' setting available. Enable this when the used Unity input manager key is a joypad axis to support down, hold and up actions.
- new: GUI Boxes: Choice Settings: 'Define Choice Height' settings available. Optionally defines the height of choices - content exceeding the height will not be visible. If disabled, the choice height is adjusted to the content of the choice.
- new: Schematic Nodes: Change Music Volume: 'Change Music Volume' node available. Changes the music volume - either sets or fades the volume. This will change the overall music volume, not the volume of the currently playing music.
- new: Schematic Nodes: Change Sound Volume: 'Change Sound VOlume' node available. Changes the sound volume - either sets or fades the volume. Already playing audio clps will not be updated by this.
- new: Schematic Nodes: Change Camera Options: 'Field of View' settings available. Optionally changes the field of view of a camera.
- new: Schematic Nodes: Shake Camera: 'Shake X-Axis', 'Shake Y-Axis' and 'Shake Z-Axis' settings available. You can now optionally shake the camera on each axis. By default shakes on the X-axis.
- new: Schematic Nodes: Start Machine, Start Tagged Machine: 'Copy Variables' setting available when using 'Share Local Variables'. The started machine will optionally use a copied set of variables instead of using the same variables. Changes to copied variables will not be available in the schematic that started the machine.
- new: Schematic Nodes: NavMesh Remaining Distance: 'NavMesh Remaining Distance' node available. Checks the remaining distance of NavMesh agents to their destinations.
- new: Schematic Nodes: Check Angle: 'Use Absolute Value' setting available. Uses the absolute value of the angle for the check, e.g. -90 will become 90.
- new: Schematic Nodes: Vector3 Check Distance: 'Vector3 Check Distance' node available. Checks the distance between 2 Vector3 values against a defind value.
- new: Rotation Component Settings: 'Rotation Function' setting available when using 'Transform' rotation component (used in 'Rotation', 'Movement' and other nodes). Either directly 'Set' the rotation or use the 'Rotate' function of the transform when rotating a game object. By default set to 'Set' (also used when using 'Auto' component).


Version 1.0.1:
- new: Input Keys: Touch: 'Consume Fingers' setting available. Optionally consumes the fingers used for the touch input, making them unavailable for other touch interactions (e.g. 'Control' type HUDs).
- new: Menu Settings, GUI Boxes: GUI Skis: 'Fade Button Children' setting available when using 'New UI' gui system type. Optionally fades the alpha or color of button child objects (i.e. text, images) on state change (selected, inactive, ...). Setting available for each button prefab individually (when used).
- new: Vector3 Values: 'Velocity' selection available in all Vector3 fields ('Game Object' value type). Uses the velocity of a 'Rigidbody' or 'Rigidbody2D' component as value. Also available in the 'Clamp Transform' node to directly clamp the velocity of a rigidbody.
- new: Schematics: Object Selections: 'Use Root' setting available in all game object selections. Uses the root object of the game object - when using 'Child Object', they'll be searched from the root.
- new: Schematic Nodes: Smooth Follow: 'Follow X Position', 'Follow Y Position' and 'Follow Z Position' settings available. Following the different position axes is now optional, e.g. you can only follow the X and Y position of a game object. By default enabled.
- new: Schematic Nodes: Raycast: 'Raycast All' setting available. Optionally uses all game objects hit by the raycast, stored variables will be added to variable lists. If disabled, only the first game object hit by the raycast will be used.
- new: Schematic Nodes: Raycast: 'Filter Game Objects' settings available. Optionally filters the found game objects by name, tag or attached components, and excludes defined game objects. This setting replaces 'Ignore User' when using 'Game Object' ray origin.
- new: Schematic Nodes: Shapecast: 'Shapecast' node available. Casts a shape into the scene and optionally uses the hit game objects or stores hit values into variables. Capsule and sphere shapes use 'Collider' components. Box and circle shapes use 'Collider2D' components.
- new: Schematic Nodes: Check Shape: 'Check Shape' node available. Checks if any colliders overlap a shape and optionally uses the hit game objects (except capsule shape). Capsule and sphere shapes use 'Collider' components. Box, circle and point shapes use 'Collider2D' components.
- new: Schematic Nodes: Change Playback Position: 'Scope' setting available. Defines if a single or all audio sources on the game object or in child objects, parent objects or from the object's root will change the playback position.
- new: Schematic Nodes: Audio Source Settings: 'Scope' setting available. Defines if a single or all audio sources on the game object or in child objects, parent objects or from the object's root will change settings.
- new: Schematic Nodes: Remove Component: 'Scope' setting available. Defines if a single or all components on the game object or in child objects, parent objects or from the object's root will be removed.
- new: Schematic Nodes: Enable Component: 'Scope' setting available. Defines if a single or all components on the game object or in child objects, parent objects or from the object's root will be enabled or disabled.
- new: Schematic Nodes: Emit Particles: 'Scope' setting available. Defines if a single or all emitters on the game object or in child objects, parent objects or from the object's root will be start or stop emitting particles.
- new: Schematic Nodes: Collider Expand: 'Scope' setting available. Defines if a single or all colliders on the game object or in child objects, parent objects or from the object's root will be expanded.
- new: Schematic Nodes: Collider Change Trigger: 'Scope' setting available. Defines if a single or all colliders on the game object or in child objects, parent objects or from the object's root will be change their 'Is Trigger' setting.
- new: Schematic Nodes: Collider Check Trigger: 'Scope' setting available. Defines if a single or all colliders on the game object or in child objects, parent objects or from the object's root will be checked.
- new: Schematic Nodes: Collider Intersect Ray, Collider Intersect Bounds: 'Scope' setting available. Defines if a single or all colliders on the game object or in child objects, parent objects or from the object's root will be used.
- new: Schematic Nodes: Object Blink Visible: 'Scope' setting available. Defines if a single or all renderers and projectors on the game object or in child objects, parent objects or from the object's root will blink.
- new: Schematic Nodes: Ignore Collision: 'Ignore Collision' node available. Enables or disables if collision between two colliders is ignored.
- new: Schematic Nodes: Ignore Layer Collision: 'Ignore Layer Collision' node available. Enables or disables if collision between colliders on two layers are ignored.
- new: Schematic Nodes: Check Ignore Layer Collision: 'Check Ignore Layer Collision' node available. Checks if collision between colliders on two layers are ignored. Optionally stores if collisions are ignored into a bool variable.
- new: Schematic Nodes: Check Object Name: 'Check Type' setting available. You can now check if the name/tag of the game object equals, starts with, ends with or contains the defined value.
- new: Schematic Nodes: Stop Global Machine: 'Stop Global Machine' node available. Stops a global machine if it's currently playing and and not using the 'Multi' execution type.
- new: Schematic Nodes: Start Machine: 'Int Variable Counter' settings available. Optionally set an int variable as counter for started machines. The int variable will be set to the number of started machines before starting a machine, i.e. the 1st machine will have value 0, 2nd machine will have value 1, etc.
- new: Trigger Machines, Scene Changers: Start Settings: 'Start By Collider' setting available. The trigger machine can be started by colliders with 'Is Trigger' disabled.
- new: Trigger Machines, Scene Changers: Start Settings: 'Start By Trigger' setting available. The trigger machine can be started by colliders with 'Is Trigger' enabled.
- new: Collision Machines, Trigger Machines: 'Check Type' setting available in start object checks when allowing the machine to be started by other game objects. Checks if the name/tag of a game object equals, starts with, ends with or contains the defined text.
- new: Collision Machines, Trigger Machins: 'Is Valid' setting available in start object checks when allowing the machine to be started by other game objects. Defines if the check needs to be valid to start the machine by a game object. E.g. disabling is valid would check for a component not to be attached.
- change: Schematic Nodes: Renderer Nodes: 'Use All' has been replaced by 'Scope' setting. Use either a single or all colliders on the game object or in child objects, parent objects or from the object's root.
- change: Schematic Nodes: Raycast: The 'Raycast' node can now be foundin 'Game Object > Raycast > Raycast'.
- fix: Node Editor: Fixed some some issues with updating connections after removing a node.
- fix: Schematic Nodes: Renderer Nodes: Missing object selections are now visible in all renderer nodes.
- fix: Schematic Nodes: Spawn Prefab: Spawning on 'First' or 'Random' game object will now recognize the rotation settings.
- fix: UI: Fixed an issue when using Unity 5.1 and the new UI.


Version 1.0.0:
Initial release.

