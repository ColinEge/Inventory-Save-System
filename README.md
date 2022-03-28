# Inventory Save System
## Added Files:
### InventorySaveLoad
Reads and Writes a save file in JSON based on the ```InventoryHolder``` found on the same GameObject

## Edited Files (and their changes):
### InventoryHolder
* Added clear function

### InventoryChannel
* Added 3 new callbacks and invocations, used to clear, export and import a save file

### InventorySlot
* Added ```Newtonsoft.Json``` namespace and json properties to inform serialiser what to convert

### Inventory
* Added Serialize function

* Added Deserialize function

* Added JsonDataObject (The object to represent the deserialized data before converting to inventory slots)

## How to set up and use:
#### Setup:
1. Move all ```InventoryItem``` ```ScriptableObject``` to ```Resources``` directory.

>Defaults to ```"Assets/Resources/ScriptableObjects/Items"```

2. Add ```InventorySaveLoad``` to the scene on the same GameObject as a ```InventoryHolder``` 
3. Assign it the appropriate inventory channel

#### Usage:
1. Call ```RaiseInventoryImport()``` from the ```InventoryChannel``` ```ScriptableObject```
2. Call ```RaiseInventoryExport()``` from the ```InventoryChannel``` ```ScriptableObject```