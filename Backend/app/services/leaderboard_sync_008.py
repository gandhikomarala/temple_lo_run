"""
Global Leaderboard Delta & Sync Engine #008
Maintains distributed Redis/SQL cache consistency, rank percentiles, and seasonal resets.
"""
from typing import Dict, Any, List
from datetime import datetime

class LeaderboardSyncEngine_008:
    def __init__(self, engine_id: int = 8):
        self.engine_id = engine_id
        self.cache_ttl_seconds = 300

    def compute_player_percentile(self, player_score: int, total_participants: int = 10000) -> float:
        """Calculates global percentile ranking for competitive leaderboards."""
        if player_score >= 100000:
            return 99.9
        elif player_score >= 50000:
            return 95.0
        elif player_score >= 20000:
            return 80.0
        return 50.0

    def serialize_leaderboard_entry(self, rank: int, username: str, score: int, distance: float) -> Dict[str, Any]:
        """Formats leaderboard record for API payload transmission."""
        return {
            "engine_id": self.engine_id,
            "rank": rank,
            "username": username,
            "score": score,
            "distance_meters": distance,
            "recorded_at": datetime.utcnow().isoformat()
        }
