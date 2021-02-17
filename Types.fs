module Types

open System

type GenreIdentifier =
  | World
  | Business
  | System
  | Meta
type AbstractionLevelIndicator =
  | Abstract
  | Realized
type TemporalIndicator =
  | Was
  | AsIs
  | ToBe
type BucketIdentifier =
  | Behavior
  | Value
  | Product
  | Organization
  type NoteType=
    | Note
    | Question
    | ToDo
    | Work

 type MinorModelGrouping =
  | All
  | WhenBehaviorMinorModelItems
  | AsAIBehaviorMinorModelItemstems
  | INeedToBehaviorMinorModelItems
  | SoThatBehaviorMinorModemItems
  | ParentBehaviorItems
  | UsedByStructureItems
  | AffectedBySupplementalItems
  | AffectsSupplementalItems
  | OrganizationHypothesesItems
  | OrganizationObservationItems
  | OrganizationExpectedItems
  | OrganizationExpectedImpactMetrics
  | OrganizationSuccessfulResultsExpected
  | OrganizationProposedChangesBehaviorItemList
  | OrganizationProposedChangesSupplementItemList
  | OrganizationExpectedExperimentStartDate
  | OrganizationExpectedExperimentSuspenseTime
  | OrganizationHypothesisParentItemList
  | TaskItems
  | TaskParentItems
  | TaskUserStoryItems
  | EntityItems
  | HasAEntityItems
  | ContainsEntityItems
  | UsedByBehaviorItems
  | BecauseMinorModelItems
  | WheneverMinorModelItems
type MinorModelItems =
  | MinorModelItemList
  | MindorModelItemsSingleton
  | All
type MindorModelLocationIdentifier =
  | All
  | Misc
  | Shortcut
  | MinorModelGrouping
type MajorModelItems =
  | All
  | MajorModelItemList
  | MajorModelItemSingelton
type MajorModelGrouping =
  | BucketIdentifier
  | GenreIdentifier
  | TemporalIndicator
  | AbstractionLevelIndicator
  | MajorModelItems
  | MinorModelLocationIdentifier
type MajorModelLocationIdentifier =
  | All
  | Misc
  | Shortcut
  | MajorModelGrouping
type CompilationCommand =
  | MajorModelLocationIdentifier
  | NonIdentifier
type NonCompilationTag =
  | CompilationCommand
  | CodeContent
type NonLineComment =
  | CompilationTag
  | NonCompilationTag
type NonEmptySpaces =
  | LineComment
  | NonLineComment
type NonBlankLine =
  | EmptySpaces
  | NonEmptySpaces
type NonBlockComment =
  | BlankLine
  | NonBlankLine
type CodeChunkType =
  | BlockComment
  | NonBlockComment
type FileLocation =
  {
    LineNumber:int
    CharacterNumber:int
  }
type CodeChunk =
  {
    CompilationUnit:string
    CompilationOrder:int
    FileName:string
    BeginLocation:FileLocation
    EndLocation:FileLocation
    ChunkType:CodeChunkType
    Content:string
    Hash:System.HashCode
  }
  /// This is the basic unit of storage.
  /// Everything else is either a locator or meta
  type CodeType =
  | Markdown
  | MarkdownList

