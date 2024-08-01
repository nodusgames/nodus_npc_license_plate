# nodus_npc_license_plate
Enables you to customise the license plates of NPC vehicles, the default format is that of the British Number plate eg. FX10 ABC

## Installation
1. Download latest release.
2. Extract folder `license_plate` to resources directory.
3. Add `ensure license_plate` to `server.cfg`

## Configuration
If you just want the British format you don't need to do anything further as the default format is `AA11-AAA` which will generate random a number plates in the correct format.  If you want to modify the layout or customise the plate text using the following instuctions.

### Pattern string format
- 1 will lead to a random number from 0-9.
- A will lead to a random letter from A-Z.
- . will lead to a random letter or number, with 50% probability of being either.
- ^1 will lead to a literal 1 being emitted.
- ^A will lead to a literal A being emitted.
- Any other character will lead to said character being emitted.
- A string shorter than 8 characters will be padded on the right.

`AA11-AAA` possible output would be `FX10 ABC`

If you want all of your vehicles to start with a specific letter or number you can specify the format in the `server.cfg` file.

`setr license_plate_pattern "MB11-AAA"` all plates will start with the letters `MB`

`setr license_plate_pattern "^A^A11-AAA"` all plates will start with the letters `AA`

## Dependency
* None- 
