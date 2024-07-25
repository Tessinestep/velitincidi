void CancelActiveTasks()
{
    if (followCursorAbilityTask != null && followCursorAbilityTask.IsActive())
    {
        followCursorAbilityTask.Cancel();
    }

    if (moveCharacterToCursorAbilityTask != null && moveCharacterToCursorAbilityTask.IsActive())
    {
        moveCharacterToCursorAbilityTask.Cancel();
    }
}
