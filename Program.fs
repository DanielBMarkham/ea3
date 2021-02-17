
open System
open FParsec
open Tests

let n:Parser<string,string> = pstring "dog"

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
type CodeType =
  | Markdown
  | MarkdownList
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


let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#"
    printfn "Hello world %s" message
    0