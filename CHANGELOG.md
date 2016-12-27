# Change Log
All notable changes to this project will be documented in this file.
This project adheres to [Semantic Versioning](http://semver.org/).

## [1.2.0] - [unreleased]

### Fixed
- Quick Convert does not work properly on multiple Excel instances. (#17)

## [1.1.0] - 2016-01-02

### Added
- "High quality table" border configuration for LatexTableConverter. (#3)
- Added new target table format: Markdown (#14)

### Changed
- LatexTableConverter: Removed `[!ht]` option from table environment. (#13)
- Convert dialog is now non-modal (#16)

## [1.0.0] - 2015-09-26

### Added
- Bold and italic is considered in Jira table converter. (#10)
- Jira extended feature: "First row is header". (#6)
- Added "About ExcelTableConverter" dialog. (#8)

### Changed
- Convert dialog opens now in the center of the Excel window. (#9)
- Click on "Save" button with no file specified opens "save file" dialog. (#11)

### Fixed
- Grey background in icon for "Quick Convert" context menu entry is now white. (#4)

## [0.9.0] - 2015-09-15
### Added
- Initial public GitHub release supporting LaTex and Atlassian Jira table formats.