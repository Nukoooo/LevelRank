# LevelRank

A ranking and leveling plugin for Counter-Strike 2 servers running on [ModSharp](https://github.com/Kxnrl/modsharp-public).

## Features

- Track player statistics and scores based on in-game actions
- Support for multiple database backends (SQLite, MySQL, PostgreSQL)
- Configurable score values for various actions:
  - Kills, deaths, assists, headshots
  - Knife/Zeus/utility kills
  - Bomb plants and defuses
  - Hostage rescues
  - Round wins/losses
- Customizable chat message colors
- Localization support

## Installation

1. Download the zip file from the latest release page
2. Extract folders from the zip files to `{YOUR_CS2_FOLDER}/game/sharp/`
3. Configure your database connection in `sharp/configs/levelrank.jsonc`
4. Edit rewards/penalties in `sharp/configs/levelrank.cfg` to your like
5. Start the server

## License

This project is licensed under the [GNU Affero General Public License v3.0](LICENSE).
