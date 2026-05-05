class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
        // We use arrays of sets (or bitsets) to track seen numbers
    bool rows[9][9] = {false}; 
    bool cols[9][9] = {false};
    bool boxes[9][9] = {false};

    for (int r = 0; r < 9; r++) {
        for (int c = 0; c < 9; c++) {
            if (board[r][c] == '.') continue;

            int num = board[r][c] - '1'; // Convert '1'-'9' to index 0-8
            int box_index = (r / 3) * 3 + (c / 3);

            // If we've seen this number in this row, col, or box before...
            if (rows[r][num] || cols[c][num] || boxes[box_index][num]) {
                return false;
            }

            // Mark as seen
            rows[r][num] = true;
            cols[c][num] = true;
            boxes[box_index][num] = true;
        }
    }
    return true;
        
    }
};
