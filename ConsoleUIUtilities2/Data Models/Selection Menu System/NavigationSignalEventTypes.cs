namespace ConsoleUIUtilities2;

/// <summary>
/// Navigation signals that can be sent to the consumer
/// </summary>
public enum NavigationSignalEventTypes
{
    NONE,
    NAVIGATE_UP,
    NAVIGATE_DOWN,
    NAVIGATE_LEFT,
    NAVIGATE_RIGHT,
    SELECTION_MADE,
    CANCELLATION,
    NEXT_PAGE,
    PREV_PAGE
}