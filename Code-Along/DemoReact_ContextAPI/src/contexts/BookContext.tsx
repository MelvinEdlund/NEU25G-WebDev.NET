// Detta är en hook som ingår i ContextAPI
import { createContext } from "react";

import type { BookContextType } from "../types/Types";

// Denna används sedan till providern
export const BookContext = createContext<BookContextType | null>(null);
